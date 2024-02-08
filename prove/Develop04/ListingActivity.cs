using System;

class ListingActivity:Activity
{
    int _count;
    List<string> _prompts = new List<string>();

    public ListingActivity(): base()
    {
        _count = 0;
        _prompts = new List<string> { "Write", "Display", "Load", "Save", "Quit" };
    }

    public void Run()
    {
        
        _prompts.Add("Write");
        _prompts.Add("Display");
        _prompts.Add("Load");
        _prompts.Add("Save");
        _prompts.Add("Quit");
    } 

    public void GetRandomPrompt()
    {
        Console.WriteLine(_prompts[_count]);
        _count++;
    } 

    public string GetListFromUser()
    {
        Console.Write("What will You like to do? ");
        return Console.ReadLine();
    }
}