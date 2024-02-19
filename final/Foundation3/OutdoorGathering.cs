using System;

class OutdoorGathering : Event
{
    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address) : base(title, description, date, time, address) { }

    public override string GetStandardDetails() => $"{title} on {date.ToShortDateString()} at {time.ToString("t")} at {address.GetFullAddress()}";

    public override string GetFullDetails() => $"{GetStandardDetails()}\n Open Air Gathering";

    public override string GetShortDescription() => $"{title} on {date.ToShortDateString()}";
}
