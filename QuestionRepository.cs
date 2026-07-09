public class QuestionRepository
{
    public List<QuizQuestion> GetQuestions()
    {
        return new List<QuizQuestion>
         {
             new QuizQuestion
             {
                 QuestionText = "Was ist Git?",
                 Answers = new List<string>
                 {
                    "Ein Texteditor",
                    "Ein Versionsverwaltungssystem",
                    "Eine Programmiersprache",
                    "Ein Datenbankserver"
                 },
                 CorrectAnswerIndex = 1
             },
             new QuizQuestion
             {
                 QuestionText = "Welche Aussage über Git stimmt?",
                 Answers = new List<string>
                 {
                    "Git ist ein Online-Repository.",
                    "Git funktioniert auch ohne Internetverbindung.",
                    "Git benötigt ein Nutzerkonto.",
                    "Git ist auf Windows vorinstalliert."
                 },
                 CorrectAnswerIndex = 1
             },
             new QuizQuestion
             {
                 QuestionText = "Was beinhaltet die Staging Area?",
                 Answers = new List<string>
                 {
                    "Alle geänderten Dateien",
                    "Die Dateien, die im letzten Commit verändert wurden",
                    "Alle Dateien des Repositories",
                    "Die Dateien, die im nächsten Commit beinhaltet sein sollen"
                 },
                 CorrectAnswerIndex = 3
             },
             new QuizQuestion
             {
                 QuestionText = "Was enthält der .git-Ordner?",
                 Answers = new List<string>
                 {
                    "Die Dateien des Repositories",
                    "Die Dateien der Staging Area",
                    "Die Commit-Geschichte",
                    "Die seit dem letzten Commit geänderten Dateien"
                 },
                 CorrectAnswerIndex = 2
             },
         };
    }
}
