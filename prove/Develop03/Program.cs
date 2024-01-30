using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Reference r = new Reference("Johns", 3, 16);
        Console.WriteLine(r.ToString());
        Word w = new Word("please wait...");
        Console.WriteLine(w.GetDisplayText("yes"));
        
        
        

    }
}