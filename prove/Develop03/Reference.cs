using System;
using System.Threading.Tasks.Dataflow;
public class Reference
{
    private string _book;
    private int _chapter;

    private int _verse;
    private int _endverse;
    private string _bookOneVerse;
    private string _bookMultiVerse;

    public bool choice = true;

    public Reference(string book, int chapter, int verse)
    {
        _book = "John";
        _chapter = 3;
        _verse = 16;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = "Proverbs";
        _chapter = 3;
        _verse = 5;
        _endverse = 6;
    }

    public void GetDisplayText()
    {
        
        _bookOneVerse =  _book + _chapter + ":" + _verse;
        Console.WriteLine(_bookOneVerse);
        _bookMultiVerse = _book + _chapter + ":" + _verse + _endverse;
        /*if (choice==true){
            Console.WriteLine(_bookOneVerse);
        }else{
            Console.WriteLine(_bookMultiVerse);

        }*/


    }


}