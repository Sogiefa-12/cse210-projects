using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static System.Console;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

public class Journal
{
    public List<Entry>_entries = new List<Entry>();

    public string JournalFIle = "MyJournal.txt";
    

    public void AddEntry ()
    {
        ForegroundColor = ConsoleColor.Black;
        WriteLine("\n What would You like to add: ");
        Entry entry = new Entry();
        entry.Display();
        ForegroundColor = ConsoleColor.DarkMagenta;
        string newline = ReadLine();
        WriteLine("The Journal has been modified");
        WaitForkey();

    }

    public void DisplayAll ()
    
    {
        //Entry entry = new Entry();
        PromptGenerator prompter  = new PromptGenerator();
        
        DisplayIntro();
        CreateJournalFile();
        LoadFromFile();
        AddEntry();
        ClearFile();
        LoadFromFile();
        //entry.Display();
        prompter.promptGenerator();
        DisplayOutro();
    }

    public void DisplayIntro()
    {

        ForegroundColor = ConsoleColor.Black;
        BackgroundColor = ConsoleColor.White;
        Clear();
        WriteLine("Welcome to the Best Journal App");
    }

    public void WaitForkey()
    {
        ForegroundColor = ConsoleColor.DarkGray;
        WriteLine("\n Press any Key>>>");
    
    }

    public void DisplayOutro()
    {
        WriteLine("Thanks for Using the Journal");
        WaitForkey();
    }

    // Check if file exist, and if doest not create one
    private void CreateJournalFile()
    {
        if (!File.Exists(JournalFIle))
        {
            File.CreateText(JournalFIle);
        }
    }

    public void SaveToFile (string file)
    {
        
    }

    public void LoadFromFile ()
    {
        ForegroundColor = ConsoleColor.DarkMagenta;
        string journalText =  File.ReadAllText(JournalFIle);
        WriteLine("\n=== Journal Contents ====: ");
        WriteLine(journalText);
        WriteLine("===========================");
        WaitForkey();
    }

    private void ClearFile() 
    {
        ForegroundColor = ConsoleColor.Black;
        File.WriteAllText(JournalFIle, "");
        WriteLine("\n Journal cleared!");
        WaitForkey();
    }

}

