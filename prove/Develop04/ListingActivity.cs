using System;
using System.Collections.Generic;
using System.Diagnostics;

class ListingActivity:Activity
{
    int _count;
    List<string> _prompts = new List<string>();
    List<string> userInputList = new List<string>();
    Stopwatch stopwatch = new Stopwatch();
  

    public ListingActivity(): base()
    {
        _count = 0;
        _prompts = new List<string> 
        {
              
        "who are people that you appreciate?",
        "what are personal strengths yours?",
        "who are people that you have helped this week?",
        "when have you felt the Holyghost this month?",
        "who are some of your personal heroes?",
        "who are people that you appreciate?",
        "what are personal strengths yours?",
        "who are people that you have helped this week?",
        "when have you felt the Holyghost this month?",
        "who are some of your personal heroes?",
        "who are people that you appreciate?",
        "what are personal strengths yours?",
        "who are people that you have helped this week?",
        "when have you felt the Holyghost this month?",
        "who are some of your personal heroes?"
    
        };
    }
 
    public void Run()
    {
        Console.WriteLine("Welcome to ListingActivity");
        Console.WriteLine("This activity will help you reflect on the  good things in your life by having you list as many things as you can in a certain time area");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string input = Console.ReadLine();
        int duration = int.Parse(input);
        Console.WriteLine($"Get ready for Your Listing Activity for  {duration} seconds");
        
        for (int i = 0; i < duration; i++)
        {
           
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Listing");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(_prompts[_count]);
            _count++;
            Console.WriteLine("   ");        

        }
    } 

    public void GetRandomPrompt()
    {
        Console.WriteLine(_prompts[_count]);
        _count++;
    } 



    public void GetListFromUser()
    {
        /**
        Console.Write("What do have in mind to List: ");
        string userInput = Console.ReadLine();
        _userList.Add(userInput);
        Console.WriteLine("Below is Your List:");
        foreach (var item in _userList)
        {
            Console.WriteLine(item);
        }
        return _userList.ToString();
        **/
        Console.WriteLine("What do have in mind to List: ");
        Console.Write("Enter the duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter items. Type '0' to stop entering items:");


        string input = "";
        while (true)
        {
            stopwatch.Start();
            input = Console.ReadLine();
            stopwatch.Stop();

            if (input == "0" || stopwatch.ElapsedMilliseconds > TimeSpan.FromSeconds(duration).Milliseconds)
            {
                break;
            }

            userInputList.Add(input);
        }

        Console.WriteLine("\nItems entered:\n");
        foreach (string item in userInputList)
        {
           
            
            Console.WriteLine(item);
        }

        return userInputList.ToString();

        
    }

    
}