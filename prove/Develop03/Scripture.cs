using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
public class Scripture
{
   
   private Reference _reference;
   private List<Word> _words;

   public Scripture(Reference reference, List<Word> words)
   {
      _reference = reference;
      _words = words;
      
   }

   public void HideRandomWords(int numberToHide)
   {
      var randomWords = _words.OrderBy(w => Guid.NewGuid()).Take(numberToHide);
      foreach(var word in randomWords)
      {
         Console.WriteLine(word);
      }

   }

   public string GetDisplayText()
   {
      return Console.ReadLine();
   }
}