using System;

class Reception: Event
{
    private string emailForRSVP;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string emailForRSVP):base(title, description, date, time, address)
    {
        this.emailForRSVP = emailForRSVP;
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