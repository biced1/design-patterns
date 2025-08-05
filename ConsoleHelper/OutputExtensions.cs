namespace ConsoleHelper;

public static class OutputExtensions
{
    public static void ListItems(this IConsole console, List<string> items)
    {
        for (int x = 0; x < items.Count; x++)
        {
            console.WriteLine($"{x + 1}: {items[x]}");
        }
        console.WriteLine("b: back");
        console.WriteLine("q: quit");
    }
}
