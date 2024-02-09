using System;
class BreathingActivity: Activity

{
    
    public BreathingActivity(string name, string description, int duration): base(name, description, duration)
    {
        _duration = duration;
        Console.WriteLine("Welcome to the breathing Activity!");
        Console.WriteLine(" This activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing. ");
        Console.WriteLine(" How long, in seconds, would you like for your session?");
        
        
    }
    public void Run()
    {
        Console.Write("Please enter a number: ");
        string input = Console.ReadLine();
        int duration = int.Parse(input);
        Console.WriteLine("Get ready to Breath for ", duration);


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