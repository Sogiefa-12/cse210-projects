using System;
using System.Collections.Generic;


class Swimming : Activity
{
    private double duration;
    private double laps;

    public Swimming(DateTime date, int duration, double laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 /1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / duration *60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }


}