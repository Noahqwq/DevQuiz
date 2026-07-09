public class QuestionRepository
{
public List<QuizQuestion> GetQuestions()
{
return new List<QuizQuestion>
{
new QuizQuestion
{
QuestionText = "Wofür steht Git?",
Answers = new List<string>
{
"Ein Texteditor",
"Ein Versionsverwaltungssystem",
"Eine Programmiersprache",
"Ein Datenbankserver"
},
CorrectAnswerIndex = 1
}
};
}
}