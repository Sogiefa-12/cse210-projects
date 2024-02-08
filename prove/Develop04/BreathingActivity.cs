//using System;
class BreathingActivity: Activity

{
    public int _duration = 0;
    public BreathingActivity(string name, string description, int duration): base(name, description, duration)
    {
        _duration = duration;
        Console.WriteLine("Welcome to the breathing Activity!");
        Console.WriteLine(" This activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing. ");
        Console.WriteLine(" How long, in seconds, would you like for your session?");
        Console.Write("Please enter a number: ",duration);
    }
    public void Run()
    {
        int duration = _duration;
        Console.WriteLine("Get Ready to Breathe For",duration);
        for (int i = 0; i < duration; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Breathe in.....", i);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

        }

    }
}