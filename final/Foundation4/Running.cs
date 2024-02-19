using System;
using System.Collections.Generic;

class Running : Activity
{
    private double distance;

    public Running(DateTime date, int duration, double distance) : base(date, duration)
{
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => (distance / duration) * 60;

    public override double GetPace() => 60 / GetSpeed();
}