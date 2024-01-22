using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static System.Console;

public class Journal
{
    public List<Entry>_entries = new List<Entry>();
    

    public void AddEntry (Entry newEntry)
    {
        
    }

    public void DisplayAll ()
    {
        Entry entry = new Entry();
        PromptGenerator prompter  = new PromptGenerator();

        DisplayIntro();
        entry.Display();
        prompter.promptGenerator();
        DisplayOutro();
    }

    public void DisplayIntro()
    {

        ForegroundColor = ConsoleColor.Black;
        BackgroundColor = ConsoleColor.White;
        WriteLine("Welcome to the Best Journal App");
        Clear();
    }

    public void DisplayOutro()
    {
        WriteLine("Thanks for Using the Journal");
    }

    public void SaveToFile (string file)
    {
        
    }

    public void LoadFromFile (string file)
    {
        
    }

    private void ClearFile() {

    }

}

