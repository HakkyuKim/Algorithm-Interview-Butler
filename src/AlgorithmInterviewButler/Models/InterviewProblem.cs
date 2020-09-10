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

    public static InterviewProblem MakeAnyProblem(){
      InterviewProblem interviewProblem = new InterviewProblem();
      interviewProblem.AlgorithmProblem = new AlgorithmProblem();
      interviewProblem.Interviewer = new Person();
      interviewProblem.Interviewee = new Person();
      return interviewProblem;
    }
  }
}