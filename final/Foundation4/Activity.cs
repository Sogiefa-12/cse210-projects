using System;
using System.Collections.Generic;

abstract class Activity
{
    private DateTime date;
    private int duration;

    protected Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;

    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"";
    }

}