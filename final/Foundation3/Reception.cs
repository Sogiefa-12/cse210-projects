using System;

class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) : base(title, description, date, time, address)
{
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetStandardDetails() => $"{title} on {date.ToShortDateString()} at {time.ToString("t")} at {address.GetFullAddress()}";

    public override string GetFullDetails() => $"{GetStandardDetails()}\n RSVP at {rsvpEmail}";

    public override string GetShortDescription() => $"{title} on {date.ToShortDateString()}";
}