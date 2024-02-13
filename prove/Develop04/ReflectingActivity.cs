//using System;

class ReflectingActivity:Activity
{
    int counter = 0;
    List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless",
        "Think of a time when you did something really hard",
        "Think of a time when assited somebody with money?",
        "Think of a time when You needed help with something?",
        "Think of a time when did not get enough money to help?",
        "Think of a time when you would have given up on your dreams"
        
    };
    List<string> _questions = new List<string>
    {
        "why was this experience meaningful to you?",
        "Have ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "what made this time different than other times when you were not successful?",
        "What is your favorite experience?",
        "what could you learn from this experience that applies to other situations?",
        "what did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity():base()
    {
      
    }

    public void Run()
    {
        Console.WriteLine("Welcome to the ReflectingActivity");
        Console.WriteLine("This activity will help you reflect on your Day. ");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        Console.Write("Please enter a number: ");
        string input = Console.ReadLine();
        int duration = int.Parse(input);
        Console.WriteLine($"Get ready to Reflect for  {duration} seconds");
       
        for (int i = 0; i < duration; i++)
        {
           
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Reflectiing");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(_prompts[counter]);
            Console.WriteLine(_questions[counter]);
            Console.WriteLine("   ");
            counter++;
            if (_questions.Count==0  & _prompts.Count==9){
                break;
            }
    
            

        }



    }

    public string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }

    public void GetQuestion()
    {
        counter = 1;
        foreach (var item in _questions)
        {
            Console.WriteLine($"{counter++}. {item}");
        
        }

        Console.WriteLine("Thats quite Alot for one Day");
    
    }

    public void DisplayPrompt()
    {

        Console.WriteLine("What will You like to do better? ");

        string UserInput = Console.ReadLine();
        while (true)
        {
            foreach (var item in _prompts)
            {
                if (item==UserInput){
                    _prompts.Add(item);
                }   
            
            }
        }

    

    }

    public void DisplayQuestion()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("What will You like to do better? ");
        Console.ForegroundColor = ConsoleColor.DarkGray;
    }

}
