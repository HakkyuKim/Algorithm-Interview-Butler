 using System;
 
 namespace AlgorithmInterviewButler.Data{
  public class InterviewProblem{

    public AlgorithmProblem AlgorithmProblem{get; set;}
    public Person SubmittedPerson{get; set;}
    public Person Interviewer {get; set;}
    public Person Interviewee {get; set;}
    public DateTime SolvedDate{get; set;}
    public DateTime SolvingTime{get; set;}

    public static InterviewProblem CreateTestData(){
      var personA = new Person{
        ID = 1,
        Name = "Hakkyu"
      };
      var personB = new Person{
        ID = 2,
        Name = "Yoojin"
      };
      return new InterviewProblem{
        AlgorithmProblem = new AlgorithmProblem{
          ID = 9206,
          Title = "I am Lazy!",
          URL = "http://baseurl.com/iamlazy",
          Difficulty = "Medium",
          Accepted = 10,
          Submitted = 20
        },
        SubmittedPerson = personA,
        Interviewer = personA,
        Interviewee = personB,
        SolvedDate = DateTime.Now,
        SolvingTime = DateTime.Now
      };
    }
  }
}