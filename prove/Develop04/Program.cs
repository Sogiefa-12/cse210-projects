using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Activity a = new Activity("John", "BreathingActivity", 30);
        a.DisplayStartingMessage();

        BreathingActivity b = new BreathingActivity(null, null, 30);
        b.Run();


        ReflectingActivity r = new ReflectingActivity();
        r.Run();
        r.GetRandomPrompt();

    }
}