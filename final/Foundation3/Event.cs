using System;

abstract class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;


    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {

    }

    public string GetStandardDetails()
    {
        return $"";
    }
    public abstract string GetFullDetails();
    public abstract string GetShortDescription();




}