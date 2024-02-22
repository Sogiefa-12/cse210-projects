using System;
using System.Collections.Generic;
using System.IO;

using System;

namespace PersonalJournal
{
    class Program
{
        static void Main(string[] args)
{
            Journal journal = new Journal();

            while (true)
            {
                Console.WriteLine("\n--- Personal Journal ---");
                Console.WriteLine("1. Write New Entry");
                Console.WriteLine("2. Display Entries");
                Console.WriteLine("3. Save Entries to File");
                Console.WriteLine("4. Load Entries from File");
                Console.WriteLine("5. Exit");

                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        journal.WriteNewEntry();
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        Console.Write("Enter the filename: ");
                        string filename = Console.ReadLine();
                        journal.SaveEntriesToFile(filename);
                        break;
                    case "4":
                        Console.Write("Enter the filename: ");
                        filename = Console.ReadLine();
                        journal.LoadEntriesFromFile(filename);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
