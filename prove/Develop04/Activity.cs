using System;
using System.Collections.Generic;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public Activity()
    {
        _name = null;
        _description = null;
        _duration = 0;

    }

    public void DisplayStartingMessage()
    {
         while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            Activity activity = null;

            switch (choice)
            {
                case 1:
                    activity  = new BreathingActivity("John", "Breathing", 30);
                    break;
                case 2:
                    activity = new ReflectingActivity();
                    break;
                case 3:
                    activity  = new ListingActivity();
                    break;
                default:Console.WriteLine("Quiting Program");
                break;
            }  

    }

/***
    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }***/

    }
}
