 using System;
 
 namespace AlgorithmInterviewButler.Data{
  public class InterviewProblem{

    public AlgorithmProblem AlgorithmProblem {get; set;}
    public Person SubmittedPerson {get; set;}
    public Person Interviewer {get; set;}
    public Person Interviewee {get; set;}
    public DateTime SolvedDate {get; set;}
    public DateTime SolvingTime {get; set;}

    public static InterviewProblem CreateTestData(){
      var rand = new Random();
      var personA = new Person{
        ID = 1,
        Name = "Hakkyu"
      };
      var personB = new Person{
        ID = 2,
        Name = "Yoojin"
      };
      InterviewProblem interviewProblem =  new InterviewProblem{
        AlgorithmProblem = new AlgorithmProblem{
          ID = rand.Next(1, 101),
          Title = "I am Lazy!",
          URL = "http://baseurl.com/iamlazy",
          Difficulty = (AlgorithmProblem.DifficultyLevel)rand.Next(4),
          Accepted = rand.Next(0, 101)
        },
        SubmittedPerson = personA,
        Interviewer = personA,
        Interviewee = personB,
        SolvedDate = DateTime.Now,
        SolvingTime = DateTime.Now
      };
      interviewProblem.AlgorithmProblem.Submitted = rand.Next(interviewProblem.AlgorithmProblem.Accepted, 101);
      return interviewProblem;
    }
  }
}