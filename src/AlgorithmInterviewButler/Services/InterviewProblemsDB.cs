using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using AlgorithmInterviewButler.Models;

namespace AlgorithmInterviewButler.Services
{
  public static class InterviewProblemsDB
  {

    private static Dictionary<int, InterviewProblem> _cachedData = new Dictionary<int, InterviewProblem>();

    static InterviewProblemsDB(){
      LoadData("../../data.json");
    }

    private static void LoadData(string filePath)
    {
      if (!filePath.EndsWith(".json"))
      {
        Console.WriteLine("[DEBUG] The passed file is not json.");
        return;
      }
      string jsonString = File.ReadAllText(filePath);
      JObject jsonObject = JObject.Parse(jsonString);

      foreach (JObject problemJson in jsonObject["stat_status_pairs"])
      {
        if((bool)problemJson["paid_only"]) continue;
        AlgorithmProblem problem = new AlgorithmProblem();
        JObject stat = (JObject)problemJson["stat"];
        problem.ID = (int)stat["question_id"];
        problem.Title = (string)stat["question__title"];
        problem.Url = (string)stat["question__title_slug"];
        problem.Accepted = (int)stat["total_acs"];
        problem.Submitted = (int)stat["total_submitted"];
        var difficultyLevel = AlgorithmProblem.DifficultyLevel.Invalid;
        switch ((int)((JObject)(problemJson["difficulty"]))["level"])
        {
          case 1:
            difficultyLevel = AlgorithmProblem.DifficultyLevel.Easy;
            break;
          case 2:
            difficultyLevel = AlgorithmProblem.DifficultyLevel.Medium;
            break;
          case 3:
            difficultyLevel = AlgorithmProblem.DifficultyLevel.Hard;
            break;
        }
        problem.Difficulty = difficultyLevel;
        InterviewProblem interviewProblem = new InterviewProblem();
        interviewProblem.AlgorithmProblem = problem;
        _cachedData.Add(interviewProblem.AlgorithmProblem.ID, interviewProblem);
      }
    }

    public static InterviewProblem GetProblem(int id)
    {
      _cachedData.TryGetValue(id, out InterviewProblem problem);
      return problem;
    }

    public static List<InterviewProblem> GetProblems(List<int> ids)
    {
      List<InterviewProblem> problems = new List<InterviewProblem>();
      foreach (int id in ids)
      {
        InterviewProblem problem = GetProblem(id);
        if (problem == null) return null;
        problems.Add(problem);
      }
      return problems;
    }
  }
}