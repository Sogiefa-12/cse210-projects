//using System;

class ReflectingActivity:Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    public ReflectingActivity():base()
    {
        _prompts.Add("Write");
        _prompts.Add("Display");
        _prompts.Add("Load");
        _prompts.Add("Save");
        _prompts.Add("Quit");
    }

    public void Run()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("What where You able Achieve today? ");
    }

    public string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        return _questions[new Random().Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("What will You like to do better? ");
        foreach (var item in _prompts)
        {
            Console.WriteLine(item);
            
        }

    }

    public void DisplayQuestion()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("What will You like to do better? ");
        Console.ForegroundColor = ConsoleColor.DarkGray;
    }

}
