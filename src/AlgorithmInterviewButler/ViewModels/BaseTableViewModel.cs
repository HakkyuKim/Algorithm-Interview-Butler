using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using AlgorithmInterviewButler.Models;
using AlgorithmInterviewButler.Services;

namespace AlgorithmInterviewButler.ViewModels {
  public abstract class BaseTableViewModel{
    private Field _previousSortedField;
    public string Title { get; set; }
    public List<Field> Fields { get; set; }
    public List<InterviewProblem> Records { get; set; }

    public BaseTableViewModel(){
      _previousSortedField = Field.None;
    }

    protected void LoadData(string filePath, string key)
    {
      Records = new List<InterviewProblem>();
      if (!filePath.EndsWith(".json"))
      {
        Console.WriteLine("[DEBUG] The passed file is not json.");
        return;
      }
      string jsonString = File.ReadAllText(filePath);
      JObject jsonObject = JObject.Parse(jsonString);

      foreach (int id in jsonObject[key])
      {
        try
        {
          Records.Add(InterviewProblemsDB.GetProblem(id));
        }
        catch (Exception ex)
        {
          Console.WriteLine($"[DEBUG] Not able to get problem id: {id}: " + ex.Message);
        }
      }
    }

    public void SortByFields(Field field, bool acending)
    {
      switch (field)
      {
        case Field.ProblemID:
          Records.Sort((x, y) => x.AlgorithmProblem.ID.CompareTo(y.AlgorithmProblem.ID));
          break;
        case Field.ProblemTitle:
          Records.Sort((x, y) => x.AlgorithmProblem.Title.CompareTo(y.AlgorithmProblem.Title));
          break;
        case Field.ProblemDifficulty:
          Records.Sort((x, y) => x.AlgorithmProblem.Difficulty.CompareTo(y.AlgorithmProblem.Difficulty));
          break;
        case Field.ProblemAcceptedCount:
          Records.Sort((x, y) => x.AlgorithmProblem.Accepted.CompareTo(y.AlgorithmProblem.Accepted));
          break;
        case Field.ProblemSubmittedCount:
          Records.Sort((x, y) => x.AlgorithmProblem.Submitted.CompareTo(y.AlgorithmProblem.Submitted));
          break;
        case Field.ProblemAcceptanceRate:
          throw new NotImplementedException();
        case Field.SubmittedPersonName:
          Records.Sort((x, y) => x.SubmittedPerson.Name.CompareTo(y.SubmittedPerson.Name));
          break;
        case Field.InterviewerName:
          Records.Sort((x, y) => x.Interviewer.Name.CompareTo(y.Interviewer.Name));
          break;
        case Field.IntervieweeName:
          Records.Sort((x, y) => x.Interviewee.Name.CompareTo(y.Interviewee.Name));
          break;
        case Field.ProblemSolvedDate:
          Records.Sort((x, y) => x.SolvedDate.CompareTo(y.SolvedDate));
          break;
        case Field.ProblemSolvingTime:
          Records.Sort((x, y) => x.SolvingTime.CompareTo(y.SolvingTime));
          break;
      }
      if (_previousSortedField == field)
      {
        _previousSortedField = Field.None;
        Records.Reverse();
      }
      else
      {
        _previousSortedField = field;
      }
    }

    public string GetValueByField(InterviewProblem interviewProblem, Field field)
    {
      switch (field)
      {
        case Field.ProblemID:
          return interviewProblem.AlgorithmProblem.ID.ToString();
        case Field.ProblemTitle:
          return interviewProblem.AlgorithmProblem.Title.ToString();
        case Field.ProblemDifficulty:
          return interviewProblem.AlgorithmProblem.Difficulty.ToString();
        case Field.ProblemAcceptanceRate:
          return ((double)interviewProblem.AlgorithmProblem.Accepted / interviewProblem.AlgorithmProblem.Submitted).ToString();
        case Field.ProblemSolvedDate:
          return interviewProblem.SolvedDate.ToString();
        case Field.ProblemSolvingTime:
          return interviewProblem.SolvingTime.ToString();
        case Field.InterviewerName:
          return interviewProblem.Interviewer.Name.ToString();
        case Field.IntervieweeName:
          return interviewProblem.Interviewee.Name.ToString();
      }
      return null;
    }
  }
}