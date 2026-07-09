public class ScoreService
{
public int CalculatePercentage(int correctAnswers, int totalQuestions)
{
if (totalQuestions == 0)
{
return 0;
}
return correctAnswers * 100 / totalQuestions;
}
}