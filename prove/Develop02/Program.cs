using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        //Console.WriteLine("Welcome To the Journal Program!");
        //Console.WriteLine("Please Select one of the following Choice");
        Journal journal = new Journal();
        

        //List<string> _prompts = new List<string>{ "Write", "Display", "Load", "Save", "Quit" };

        //foreach(string option in _prompts)
        //{
          //Console.Write( $"{_prompts.IndexOf(option)}. "); Console.WriteLine(option);
        //}

        //Console.WriteLine("What will You like to do? ");


        Entry entry = new Entry();
        //entry.Display();
        PromptGenerator prompt = new PromptGenerator();

        journal.DisplayAll();
        
    }
}