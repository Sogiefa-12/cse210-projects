using System;
public class Word
{
    string _text;
    string _text2;
    bool _isHidden;

    public Word(string text, string _text2)
    {
        _text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";

        _text2 ="Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight";
    }

    public void Hide()
    {
        Console.WriteLine(_isHidden);
        _text = "For God so loved _ _ _ _ _, that he gave his only _ _ _ _ _ _, that whosoever believeth in him should not perish, but have _ _ _ _ _ _ _ _ _ _ _";
        Console.WriteLine(_text);

        _text2 = "_ _ _ _ _ _ in the LORD with all your heart and _ _ _ _ _ _ on your own undertanding; in all _ _ _ _ _ _ _ _ _ _ _ to him, and he will make your paths _ _ _ _ _ _ _ _";
        Console.WriteLine(_text2);
  
    }

    public void Show()
    {
        Console.WriteLine(_text);
        Console.WriteLine(_text2);
    }

    public string GetDisplayText()
    {
        return _text;
    }
}
