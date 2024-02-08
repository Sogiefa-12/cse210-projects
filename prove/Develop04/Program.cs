using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Activity a = new Activity("John", "BreathingActivity", 30);
        a.DisplayStartingMessage();

        BreathingActivity b = new BreathingActivity();
        Console.WriteLine(b.Run());


        ReflectingActivity r = new ReflectingActivity();
        Console.WriteLine(r.Run());
        Console.WriteLine(r.GetRandomPrompt());

    }
}