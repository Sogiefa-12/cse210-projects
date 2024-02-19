using System;
using System.Collections.Generic;

class Cycling : Activity
{
    private double speed;
    private double duration;
    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
        this.duration = duration;
        this.date = date;

    }

    public override double GetDistance()
    {
        return duration * speed /60;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    
}