using System;
using System.Collections.Generic;

public abstract class Goal
{
    public string Name { get; }
    public int Value { get; }
    public int Bonus { get; }
    public bool IsCompleted { get; set; }
    
    protected Goal(string name, int value, int bonus)
{
        Name = name;
        Value = value;
        Bonus = bonus;
        IsCompleted = false;
    }
    
    public abstract void RecordEvent();
    public abstract void CheckCompletion();
}