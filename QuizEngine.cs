public class QuizEngine
{
private readonly QuestionRepository _questionRepository = new();
private readonly ScoreService _scoreService = new();
public void Start()
{
var questions = _questionRepository.GetQuestions();
int correctAnswers = 0;
foreach (var question in questions)
{
Console.WriteLine(question.QuestionText);
for (int i = 0; i < question.Answers.Count; i++)
{
Console.WriteLine($"{i + 1}: {question.Answers[i]}");
}
Console.Write("Antwort: ");
string? input = Console.ReadLine();
if (int.TryParse(input, out int selectedAnswer)
&& selectedAnswer - 1 == question.CorrectAnswerIndex)
{
correctAnswers++;
Console.WriteLine("Richtig!");
}
else
{
Console.WriteLine("Leider falsch oder ungültig.");
}
Console.WriteLine();
}
int percentage = _scoreService.CalculatePercentage(correctAnswers, questions.Count);
Console.WriteLine($"Richtig: {correctAnswers} von {questions.Count}");
Console.WriteLine($"Ergebnis: {percentage} %.");
}
}