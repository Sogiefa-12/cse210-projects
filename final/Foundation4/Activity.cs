using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

abstract class Activity
{
    public DateTime date;
    public int duration;

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
        return $"{date.ToShortDateString()} {ToString()} ({duration} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}







