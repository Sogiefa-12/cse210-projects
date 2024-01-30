using System;

    public class Word
{
        public string word { get; set; }
        public bool IsHidden { get; set; }

        public Word(string _word)
{
            word = _word;
            IsHidden = false;
        }

        public string GetDisplayText(string text)
    {
        word = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";
        return word;
    }

    
}



/****
public class Word
{
    string _text;
    bool _isHidden;

    public Word(string text)
    {
        _text =text;
    }

    public void Hide()
    {
        _text = "For God so _ _ _ _ world, that he gave his only begotten Son, that whosoever _ _ _ _ _ _ in him should not perish, but have _ _ _ _ _ _ _ _life";
        Console.WriteLine(_text);
    }

    public void Show()
    {
        _text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText(string text)
    {
        return text;
    }
}
***/
