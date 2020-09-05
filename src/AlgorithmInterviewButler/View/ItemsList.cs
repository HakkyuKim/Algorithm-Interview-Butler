using System.Collections.Generic;
using AlgorithmInterviewButler.Data;

namespace AlgorithmInterviewButler.View{
  public class ItemsList{
    public string Title {get; set;}
    public IList<string> RowHeader {get; set;}
    public IList<InterviewProblem> ListItems {get; set;}
  }
}