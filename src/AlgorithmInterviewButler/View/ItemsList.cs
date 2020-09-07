using System.Collections.Generic;
using AlgorithmInterviewButler.Data;
using System;

// case Field.ProblemID:
// case Field.ProblemTitle:
// case Field.ProblemDifficulty:
// case Field.ProblemAcceptedCount:
// case Field.ProblemSubmittedCount:
// case Field.ProblemAcceptanceRate:
// case Field.SubmittedPersonName:
// case Field.InterviewerName:
// case Field.IntervieweeName:
// case Field.ProblemSolvedDate:
// case Field.ProblemSolvingTime:

namespace AlgorithmInterviewButler.View
{
  public class ItemsList
  {

    public enum Field
    {
      ProblemID,
      ProblemTitle,
      ProblemDifficulty,
      ProblemAcceptedCount,
      ProblemSubmittedCount,
      ProblemAcceptanceRate,
      SubmittedPersonName,
      InterviewerName,
      IntervieweeName,
      ProblemSolvedDate,
      ProblemSolvingTime
    }

    public string Title { get; set; }
    public List<Field> RowHeader { get; set; }
    public List<InterviewProblem> ListItems { get; set; }

    public void SortByFields(Field field, bool acending)
    {
      switch (field)
      {
        case Field.ProblemID:
          ListItems.Sort((x, y) => x.AlgorithmProblem.ID.CompareTo(y.AlgorithmProblem.ID));
          break;
        case Field.ProblemTitle:
          ListItems.Sort((x, y) => x.AlgorithmProblem.Title.CompareTo(y.AlgorithmProblem.Title));
          break;
        case Field.ProblemDifficulty:
          ListItems.Sort((x, y) => x.AlgorithmProblem.Difficulty.CompareTo(y.AlgorithmProblem.Difficulty));
          break;
        case Field.ProblemAcceptedCount:
          ListItems.Sort((x, y) => x.AlgorithmProblem.Accepted.CompareTo(y.AlgorithmProblem.Accepted));
          break;
        case Field.ProblemSubmittedCount:
          ListItems.Sort((x, y) => x.AlgorithmProblem.Submitted.CompareTo(y.AlgorithmProblem.Submitted));
          break;
        case Field.ProblemAcceptanceRate:
          throw new NotImplementedException();
        case Field.SubmittedPersonName:
          ListItems.Sort((x, y) => x.SubmittedPerson.Name.CompareTo(y.SubmittedPerson.Name));
          break;
        case Field.InterviewerName:
          ListItems.Sort((x, y) => x.Interviewer.Name.CompareTo(y.Interviewer.Name));
          break;
        case Field.IntervieweeName:
          ListItems.Sort((x, y) => x.Interviewee.Name.CompareTo(y.Interviewee.Name));
          break;
        case Field.ProblemSolvedDate:
          ListItems.Sort((x, y) => x.SolvedDate.CompareTo(y.SolvedDate));
          break;
        case Field.ProblemSolvingTime:
          ListItems.Sort((x, y) => x.SolvingTime.CompareTo(y.SolvingTime));
          break;
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

    public static ItemsList CreateSolvedList()
    {
      ItemsList solvedList = new ItemsList();
      solvedList.Title = "Solved List";
      solvedList.RowHeader = new List<Field>{
        Field.ProblemID,
        Field.ProblemTitle,
        Field.ProblemDifficulty,
        Field.ProblemAcceptanceRate,
        Field.ProblemSolvedDate,
        Field.ProblemSolvingTime,
        Field.InterviewerName,
        Field.IntervieweeName
      };
      solvedList.ListItems = new List<InterviewProblem>();
      for (int i = 0; i < 10; ++i)
      {
        solvedList.ListItems.Add(InterviewProblem.CreateTestData());
      }
      return solvedList;
    }
  }
}