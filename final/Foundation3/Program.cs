using System;


class Program
{
    static void Main()
{
        Address address = new Address("123 Main St", "Los Angeles", "State", "California");

        Lecture lecture = new Lecture("Tech Talk", "Learn about new Tech", DateTime.Parse("2022-12-31 10:00"), new TimeSpan(10, 0, 0), address, "John Doe", 100);
        Reception reception = new Reception("Holiday Party", "Join us for some cheer", DateTime.Parse("2022-12-25 18:00"), new TimeSpan(18, 0, 0), address, "SaragOgiefa@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "Join us for a picnic", DateTime.Parse("2023-06-15 12:00"), new TimeSpan(12, 0, 0), address);

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}