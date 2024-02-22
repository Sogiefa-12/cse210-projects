
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Entry
{
    public DateTime Date { get; set; }
    public List<string> Prompts { get; set; }
    public List<string> Responses { get; set; }

    public Entry(DateTime date)
{
        Date = date;
        Prompts = new List<string>();
        Responses = new List<string>();
    }

    public override string ToString()
{
        string output = $"Date: {Date}\n";
        for (int i = 0; i < Prompts.Count; i++)
        {
            output += $"Prompt: {Prompts[i]}\nResponse: {Responses[i]}\n";
        }
        return output + "\n";
    }
}
