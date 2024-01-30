using System;
using System.Collections.Concurrent;


public class Reference
{
        public string Book { get; set; }
        public int? Chapter { get; set; }
        public List<int?> Verses { get; set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verses = new List<int?> { verse };
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verses = new List<int?> { startVerse, endVerse };
    }


    public override string ToString()
    {
        if (Verses.Count == 1)
            return $"{Book} {Chapter}:{Verses[0]}";
        return $"{Book} {Chapter}:{Verses[0]}-{Verses[Verses.Count - 1]}";
        }

    
}