using System.Collections.Generic;
using AlgorithmInterviewButler.Models;

namespace AlgorithmInterviewButler.ViewModels
{
  public class SolvingTableViewModel : BaseTableViewModel
  {
    public SolvingTableViewModel() : base()
    {
      Title = "Solving Table";
      Fields = new List<Field>(){
        Field.ProblemID,
        Field.ProblemTitle,
        Field.ProblemDifficulty
      };
      LoadData("../../solving.json", "solving");
    }
  }
}