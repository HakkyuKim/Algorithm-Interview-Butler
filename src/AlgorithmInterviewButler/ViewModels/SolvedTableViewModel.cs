using System.Collections.Generic;
using AlgorithmInterviewButler.Models;

namespace AlgorithmInterviewButler.ViewModels
{
  public class SolvedTableViewModel : BaseTableViewModel
  {
    public SolvedTableViewModel() : base()
    {
      Title = "Solved Table";
      Fields = new List<Field>(){
        Field.ProblemID,
        Field.ProblemTitle,
        Field.ProblemDifficulty,
        Field.ProblemAcceptanceRate
      };
      LoadData("../../solved.json", "solved");
    }
  }
}