using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


//namespace ScriptureEncapsulation.Interface
//{
    

public  class Scripture

{
    Reference _reference = new Reference();
    Word w = Word();
    private string text ;

    private static Word Word()
    {
        throw new NotImplementedException();
    }

    private List<Word>_words;

    public Scripture( string Reference, string text )
    {
        Reference = Reference;
    }

    public Scripture()
    {
    }

    public void HideRandomWords()

    {
        if(_words.Count ==0)
        return;
        int numberToHide = new Random().Next(1, Math.Min(5, _words.Count));
        List<int>randomIndex = Enumerable.Range(0, _words.Count).OrderBy(x => new Random().Next()).Take(numberToHide).ToList();
        _words.RemoveRange(5, 6);
        Console.WriteLine(numberToHide);
    }


    public string GetDisplayText()
    {
        return $"{_reference}: {string.Join(" ", _words)}";
    }

    public bool IsCompletelyHidden()
    {
         return true;
    }

    
}

//}