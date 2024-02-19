using System;

class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
{
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetStandardDetails() => $"{title} on {date.ToShortDateString()} at {time.ToString("t")} at {address.GetFullAddress()}";

    public override string GetFullDetails() => $"{GetStandardDetails()}\n Speaker: {speaker}\n Capacity: {capacity}";

    public override string GetShortDescription() => $"{title} on {date.ToShortDateString()}";
}
