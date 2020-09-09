using System;
using System.Collections.Generic;

namespace AlgorithmInterviewButler.Models
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
    public string Url {get; set;}
  }
}