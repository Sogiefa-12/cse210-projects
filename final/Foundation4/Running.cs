using System;
using System.Collections.Generic;

class Running : Activity
{
    private double distance;
    private int duration;


    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / duration * 60;
    }

    public override double GetPace()
    {
        return 60/GetSpeed();
    }
}