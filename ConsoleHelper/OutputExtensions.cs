namespace ConsoleHelper;

public static class OutputExtensions
{
    public static void ListItems(this IConsole console, List<string> items, bool listOnly = false)
    {
        for (int x = 0; x < items.Count; x++)
        {
            console.WriteLine($"{x + 1}: {items[x]}");
        }
        if (!listOnly)
        {
            console.WriteLine("b: back");
            console.WriteLine("q: quit");
        }
    }
}
