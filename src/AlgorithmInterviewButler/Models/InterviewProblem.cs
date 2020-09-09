using System;
namespace AlgorithmInterviewButler.Models
{
  public class InterviewProblem
  {

    public AlgorithmProblem AlgorithmProblem { get; set; }
    public Person SubmittedPerson { get; set; }
    public Person Interviewer { get; set; }
    public Person Interviewee { get; set; }
    public DateTime SolvedDate { get; set; }
    public DateTime SolvingTime { get; set; }
  }
}