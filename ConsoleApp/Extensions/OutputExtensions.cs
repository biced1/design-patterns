using ConsoleApp.Wrapper;

namespace ConsoleApp.Extensions;

public static class OutputExtensions
{
    /// <summary>
    /// Displays all items provided in a numbered list to the user.
    /// Optionally shows back and quit options.
    /// </summary>
    /// <param name="items">Items to display to the user.</param>
    /// <param name="listOnly">True if you should not show the back and quit options.</param>
    public static void ListItems(this IConsole console, List<string> items, bool listOnly = false)
    {
        for (int x = 0; x < items.Count; x++)
        {
            console.WriteLine($"\t{x + 1}: {items[x]}");
        }
        if (!listOnly)
        {
            console.WriteLine("\tb: back");
            console.WriteLine("\tq: quit");
        }
    }
}
