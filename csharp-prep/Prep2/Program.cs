using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("what is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";
        if (grade >=90)
        {
            letter = "A";
            
        }
        else if (grade >= 80)
        {
            letter = "B";

        }
        else if (grade >=70)
        {
            letter = "B";
        }
        else if (grade >= 60)
        {
            letter = "C";
        }
        else 
        {
            letter = "D";
        }

        Console.WriteLine($"Your Grade is: {letter}");


        if (grade >= 70)
        {
            Console.Write("Congratulations!! You did well");
        }
        else
        {
            Console.Write("try again, put more effort next time");
        }

       

    }
}