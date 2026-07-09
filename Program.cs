Console.WriteLine("Willkommen bei DevQuiz!");
Console.WriteLine();
bool running = true;
while(running == true)
{
    Console.WriteLine("1: Quiz Starten\n2: HelpService aufrufen\n0: Beenden\n>>> ");
    string? input = Console.ReadLine();

    if (input == "1")
    {
        var quizEngine = new QuizEngine();
        quizEngine.Start(); 
    }
    else if(input == "2")
    {
        Console.WriteLine("HelpService still in progress...");
        running = false;
    }
    else if(input == "0")
    {
        running = false;
    }
    else{
        Console.WriteLine("\n\n\n");
        };

}

Console.WriteLine("See you next time...");
