public class QuizQuestion
{
 public string QuestionText { get; set; } = "";
 public List<string> Answers { get; set; } = new();
 public int CorrectAnswerIndex { get; set; }
}
