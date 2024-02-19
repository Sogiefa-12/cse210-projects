using System;
using System.Collections.Generic;

class Swimming : Activity
{
    private double laps;

    public Swimming(DateTime date, int duration, double laps) : base(date, duration)
{
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000;

    public override double GetSpeed() => (GetDistance() / duration) * 60;

    public override double GetPace() => 60 / GetSpeed();
}
