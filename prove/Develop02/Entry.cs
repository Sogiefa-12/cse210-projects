using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static System.Console;
using System;
public class Entry
{
    string _date;
    string _promptText;
    string _entryText;

    public void Display()

    {
        ForegroundColor = ConsoleColor.Black;
        BackgroundColor = ConsoleColor.White;
        string _promptText = "Please Select one of the following Choice";
        DateTime todaysDate =  DateTime.Today;
        Console.Write(todaysDate); Console.WriteLine(_promptText);


    }

}