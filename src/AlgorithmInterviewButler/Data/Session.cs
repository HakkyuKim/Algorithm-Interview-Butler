using System;
using System.Collections.Generic;

namespace AlgorithmInterviewButler.Data{
  public class Session{
    public DateTime Date{get; set;}
    public IList<InterviewProblem> InterviewProblems{get; set;}
  }
}