using System;

class Program
{
    static void Main(string[] args)
    {
      
       Console.Write("What is the magic Number");
       string response = Console.ReadLine();
       int magicNumber = int.Parse(response);
       Console.Write("what is your Guess?");
       string guess = Console.ReadLine();
       int guessNumber = int.Parse(guess);

       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 101);


        guessNumber =-1;

        while (guessNumber = magicNumber)
        {
            
       
      
            if (guessNumber > magicNumber)
            { 
                Console.Write("Higher");
            }
            else if (guessNumber < magicNumber)
            {
                Console.Write("Lower");
            }

            else
            {
                Console.Write("You guessedit!!");
            }
        
         }



       }

    
}