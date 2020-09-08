using System.IO;
using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace AlgorithmInterviewButler.Data
{
  public class AlgorithmProblem
  {
    public enum DifficultyLevel{
      Invalid,
      Easy,
      Medium,
      Hard
    }

    public int ID { get; set; }
    public string Title { get; set; }
    public string URL { get; set; }
    public DifficultyLevel Difficulty { get; set; }
    public int Accepted { get; set; }
    public int Submitted { get; set; }

    public static List<AlgorithmProblem> ProblemsArchive {get; private set;}

    public static void ReadProblems(){
      ProblemsArchive = new List<AlgorithmProblem>();
      string jsonString = File.ReadAllText("../../data.json");
      JObject jsonObject = JObject.Parse(jsonString);
      
      foreach(JObject problemJson in jsonObject["stat_status_pairs"]){
        AlgorithmProblem problem = new AlgorithmProblem();
        try{
          JObject stat = (JObject)problemJson["stat"];
          int questionId = (int)stat["question_id"];
          string problemTitle = (string)stat["question__title_slug"];
          DifficultyLevel difficultyLevel = DifficultyLevel.Invalid;
          switch((int)((JObject)(problemJson["difficulty"]))["level"]){
            case 1:
            difficultyLevel = DifficultyLevel.Easy;
            break;
            case 2:
            difficultyLevel = DifficultyLevel.Medium;
            break;
            case 3:
            difficultyLevel = DifficultyLevel.Hard;
            break;
          }
          problem.ID = questionId;
          problem.Title = problemTitle;
          problem.Difficulty = difficultyLevel;
          ProblemsArchive.Add(problem);
        }catch(Exception ex){
          Console.WriteLine("[Debug]: " + ex.Message);
        } 
      }

    }
  }
}