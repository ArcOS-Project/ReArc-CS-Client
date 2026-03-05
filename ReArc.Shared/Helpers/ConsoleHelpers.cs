using System.Text;

namespace ReArc.Shared.Helpers;

public static class ConsoleHelpers
{
    public static string Prompt(string prefix, bool conceiled = false)
    {
        Console.Write(prefix);
        if (!conceiled)
        {
            return Console.ReadLine() ?? "";
        }

        StringBuilder input = new();
        while (true)
        {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter) break;
            if (key.Key == ConsoleKey.Backspace && input.Length > 0) input.Remove(input.Length - 1, 1);
            else if (key.Key != ConsoleKey.Backspace) input.Append(key.KeyChar);
        }
        Console.WriteLine("");
        return input.ToString();
    }
}
