using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello User help You Memorize the Scripture");
        Console.WriteLine("I will Display a Particular Scripture and You will  to memorize it and fill in the missing parts on the next display");
        Reference r = new Reference("Johns", 3, 16);
        Console.WriteLine(r.ToString());
        //Word w = new Word("please wait...");
        //Console.WriteLine(w.GetDisplayText());
        Word w = new Word("please wait");
        
        Scripture s = new Scripture();
        s.AddWord(w);
        s.DisplayScripture();
        Thread.Sleep(12000);
        Console.Clear();
        s.HideRandomWords();
        Thread.Sleep(12000);
        Console.Clear();

        Reference re = new Reference("Proverbs", 3, 5, 6);
        Console.WriteLine(re.ToString());
        Word w1 = new Word("Verses");
        s.DisplayScriptureMultiverse();
        Thread.Sleep(12000);
        Console.Clear();
        s.HideMultiverWords();
        Thread.Sleep(12000);
        Console.Clear();
    
        
        

    }
}