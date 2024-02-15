class Program
{
    static void Main(string[] args)
{
        User user = new User("John");

        Goal studyScripturesGoal = new SimpleGoal("Study Scriptures", 100);
        Goal attendTempleGoal = new ChecklistGoal("Attend Temple", 50, 10, 500);

        user.AddGoal(studyScripturesGoal);
        user.AddGoal(attendTempleGoal);

        user.RecordEvent(studyScripturesGoal);
        user.RecordEvent(attendTempleGoal);

        Console.WriteLine($"Score: {user.GetScore()}");

        user.CheckCompletion();
    }
}