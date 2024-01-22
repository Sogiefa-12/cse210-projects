using static System.Console;
public class PromptGenerator
{
    public List<string> _prompts;

    public void promptGenerator()
    {
        ForegroundColor = ConsoleColor.Black;
        BackgroundColor = ConsoleColor.White;
        List<string> _prompts = new List<string>{ "Write", "Display", "Load", "Save", "Quit" };

        foreach(string option in _prompts)
        {
          Console.Write( $"{_prompts.IndexOf(option)}. "); Console.WriteLine(option);
        }

    }
}