namespace AlgorithmInterviewButler.Data
{
  public class AlgorithmProblem
  {
    public enum DifficultyLevel{
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
  }
}