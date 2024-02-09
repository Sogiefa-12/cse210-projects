using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Activity a = new Activity("John", "BreathingActivity", 30);
        a.DisplayStartingMessage();
        Thread.Sleep(10000);
        Console.Clear();;

        BreathingActivity b = new BreathingActivity("John", "BreathingActivity",30);
        b.Run();

        ReflectingActivity r = new ReflectingActivity();
        r.Run();
        r.DisplayPrompt();
        r.DisplayQuestion();



    }
}