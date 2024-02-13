using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Console.WriteLine("Select an Option: ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");

        string entry = Console.ReadLine();
        Console.Write("Enter your choice: ");
        int choice = int.Parse(entry);
        while (true)
        {

            //Activity activity;
            Activity activity = new Activity("John", "BreathingActivity", 30);

            if (choice ==1)
            {
                activity  = new BreathingActivity("John", "Breathing", 30);
                BreathingActivity b = new BreathingActivity(null, null, 30);
                b.Run();
                break;
    
            }
            else if (choice == 2)
            {
                activity = new ReflectingActivity();
                ReflectingActivity r = new ReflectingActivity();
                r.Run();
                
                //r.GetRandomPrompt();

                break;
            }
            else if (choice == 3)
            {
                activity = new ListingActivity();
                ListingActivity l = new ListingActivity();
                l.Run();
                l.GetRandomPrompt();
                l.GetListFromUser();
                break;
            }
            
            else if (choice == 4)
            {
                Console.WriteLine("Quiting Program");
                break;
            }
            break;
        } 
        

        
        //a.DisplayStartingMessage();

       


       
    }
}