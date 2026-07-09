public static class HelpService
{
    private static string generalHelp = "Willkommen zum Quiz! Beantworten Sie die Fragen, indem Sie die Nummer der richtigen Antwort eingeben.\n\rJede Frage hat mehrere Antwortmöglichkeiten. Geben Sie die Nummer der Antwort ein, die Sie für richtig halten.\n\rAm Ende des Quiz wird Ihre Punktzahl angezeigt, basierend auf der Anzahl der richtigen Antworten.",
                   startMenuHelp = "Im Startmenü können Sie (1) das Quiz starten, (2) die Hilfe anzeigen oder (0) das Programm beenden.";
    public static void DisplayGeneralHelp() => Console.WriteLine(generalHelp);
    public static void DisplayStartMenuHelp() => Console.WriteLine(startMenuHelp);
}