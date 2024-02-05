using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
public class Scripture
{
   
  // private Reference _reference;
   public List<Word> _words;
   Reference r = new Reference("Johns", 3, 16);
   
   Reference re = new Reference("Proverbs", 3, 5, 6);

   
   Word words = new Word("please wait...");
   

   public Scripture()
   {
     
      _words = new List<Word>();
      
   }

   public void AddWord(Word word)
   {
      _words.Add(word);
   }

   public void HideRandomWords()
   {
      foreach(Word word in _words)
      {
         Console.WriteLine(word.HideText());
      }
   }

   public void HideMultiverWords()
   {
      foreach(Word word in _words)
      {
         Console.WriteLine(word.HideMultivere());
      }
   }
   public void DisplayScripture()
   {
      foreach(Word word in _words)
      {
         if(r.Verses.Count== 1){
            Console.WriteLine(word.GetDisplayText());
         }
         
      }
   }

   public void DisplayScriptureMultiverse()
   {
      foreach(Word word in _words)
      {
         if(re.Verses.Count>1){
            Console.WriteLine(word.GetDisplayMultiverse());
         }
      }
      
   }
}