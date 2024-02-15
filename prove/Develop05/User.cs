using System;
using System.Collections.Generic;

public class User
{
    public string Name { get; }
    public List<Goal> Goals { get; }
    public int Score { get; private set; }

    public User(string name)
{
        Name = name;
        Goals = new List<Goal>();
        Score = 0;
    }

    public void AddGoal(Goal goal)
{
        Goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
{
        goal.RecordEvent();
        Score += goal.Value;
    }

    public void CheckCompletion()
{
        foreach (var goal in Goals)
        {
            goal.CheckCompletion();
        }
    }

    public int GetScore()
{
        return Score;
    }
}