using System;

class Lecture: Event
{
    private string speakerName;
    private int capacity;
    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speakerName, int capacity): base(title, description, date, time, address)
    {

    }

    public override string GetFullDetails()
    {
        return $"";
    }

    public override string GetShortDescription()
    {
        return $"";
    }
}