using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public class Journal
{
    private List<Entry> entries;

    public Journal()
{
        entries = new List<Entry>();
    }

    public void WriteNewEntry()
{
        DateTime date = DateTime.Now;
        Entry newEntry = new Entry(date);

        foreach (var prompt in GetAllPrompts())
{
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            newEntry.Prompts.Add(prompt);
            newEntry.Responses.Add(response);
        }

        entries.Add(newEntry);
    }

    private IEnumerable<string> GetAllPrompts()
{
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
};

        return prompts;
    }

    public void DisplayEntries()
{
        foreach (var entry in entries)
        {
            Console.Write(entry.ToString());
        }
    }

    public void SaveEntriesToFile(string filename)
{
        using (StreamWriter writer = File.CreateText(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }
public void LoadEntriesFromFile(string filename)
{
    entries.Clear();

    if (File.Exists(filename))
    {
        using (StreamReader reader = File.OpenText(filename))
        {
            string entryText;
            while ((entryText = reader.ReadLine()) != null)
            {
                Entry loadedEntry = new Entry(DateTime.Now);

                string[] lines = entryText.Split(new string[] { "\n" }, StringSplitOptions.None);
                for (int i = 0; i < lines.Length; i += 2)
                {
                    if (i == 0)
                    {
                        DateTime entryDate;
                        if (DateTime.TryParse(lines[i], out entryDate))
                        {
                            loadedEntry.Date = entryDate;
                        }
                    }
                    else
    {
                        loadedEntry.Prompts.Add(lines[i]);
                        if (i + 1 < lines.Length)
                        {
                            loadedEntry.Responses.Add(lines[i + 1]);
                        }
                    }
                }
                entries.Add(loadedEntry);
            }
        }
    }
}
}