using System;
using System.Collections.Generic;


public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value, 0) { }
    
    public override void RecordEvent()
{
        IsCompleted = true;
        Console.WriteLine($"Recorded event for {Name}. Goal completed.");
    }
    
    public override void CheckCompletion()
{
        if (IsCompleted)
        {
            Console.WriteLine($"{Name} has been completed. No further events can be recorded for this goal.");
        }
        else
{
            Console.WriteLine($"{Name} has not been completed.");
        }
    }
}