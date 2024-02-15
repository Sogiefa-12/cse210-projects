using System;
using System.Collections.Generic;
using System.Diagnostics;

class ListingActivity:Activity
{
    int _count;
    List<string> _prompts = new List<string>();
    List<string> userInputList = new List<string>();
    Random random = new Random();
  

    public ListingActivity(): base()
    {
        _count = 0;
        _prompts = new List<string> 
        {
              
        "who are people that you appreciate?",
        "what are personal strengths yours?",
        "who are people that you have helped this week?",
        "when have you felt the Holyghost this month?",
        "what is your most memorable day on earth?",
        "Do you have a personal relationship with Holy Gost?",
        "who is the Holy Ghost to You?",
        "How often do you tell people about Christ?",
        "when have you felt the Holyghost this month?",
        "who are some of your personal heroes?",
        "who are people that you appreciate?",
        "What are your personal achievement you are proud of?",
        "who are people that you have helped this week?",
        "Do have a personal relationship with Christ?"
    
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
        foreach (var item in  _prompts)
        {
            Console.WriteLine(item);
        }

        while (_prompts.Count > 0)
        {
            int index = random.Next(_prompts.Count);
            Console.WriteLine(_prompts[index]);
            _prompts.RemoveAt(index);
        }
     //   Console.WriteLine(_prompts[_count]);
       // _count++;
    } 



    public void GetListFromUser()
    {
       
        Console.WriteLine("What do have in mind to List: ");
        //int duration = int.Parse(Console.ReadLine());

         Console.WriteLine("Enter your responses one at a time. Type 'DONE' when you are finished.");

        string input;
        do
        {
            input = Console.ReadLine();
            userInputList.Add(input);

            if (input.ToLower() == "done")
            {
                break;
            }
        } while (true);

        Console.WriteLine("\nYour responses:");

        foreach (var response in userInputList)
        {
            Console.WriteLine(response);
        }
    }
}