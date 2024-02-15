using System;
using System.Collections.Generic;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value, 0) { }
    
    public override void RecordEvent()
{
        Console.WriteLine($"Recorded event for {Name}. Goal updated.");
    }
    
    public override void CheckCompletion()
{
        Console.WriteLine($"{Name} is an eternal goal. It doesn't have completion status.");
    }
}