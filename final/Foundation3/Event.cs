using System;
using System.Collections.Generic;
abstract class Event
{
    public string title;
    public string description;
    public DateTime date;
    public TimeSpan time;
    public Address address;
    
    protected Event(string title, string description, DateTime date, TimeSpan time, Address address)
{
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public abstract string GetStandardDetails();
    public abstract string GetFullDetails();
    public abstract string GetShortDescription();
}