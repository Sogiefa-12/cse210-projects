using System;
using System.Collections.Generic;
public class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, int value, int count, int bonus) : base(name, value, bonus)
{
        TotalCount = count;
    }
    
    public int CurrentCount { get; set; }
    
    public int TotalCount { get; }
    
    public override void RecordEvent()
{
        CurrentCount++;
        Console.WriteLine($"Recorded event for {Name}. Goal progress updated.");
        CheckCompletion();
    }
    
    public override void CheckCompletion()
{
        if (CurrentCount >= TotalCount)
        {
            Console.WriteLine($"{Name} has been completed. Bonus applied.");
            CurrentCount = TotalCount;
        }
        else
{
            Console.WriteLine($"{Name} has not been completed. Remaining events to complete: {TotalCount - CurrentCount}");
        }
    }
}