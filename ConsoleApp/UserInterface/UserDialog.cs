using DesignPatterns.ConsoleHelper;
using DesignPatterns.Factory.UserInterface;

namespace DesignPatterns.UserInterface;

public static class UserDialog
{
    public static void Run(IConsole console)
    {
        var dialogs = new List<IUserDialog>
        {
            new FactoryUserDialog()
        };

        console.WriteLine("Welcome to Design Patterns.");
        var message = "What kind of design pattern would you like to test?\n";

        for (int x = 0; x < dialogs.Count; x++)
        {
            message += $"{x + 1}: {dialogs[x].GetType().Name}\n";
        }
        var factoryChoice = InputHelper.GetIntInput(console, message, 1, dialogs.Count);
        console.WriteLine(factoryChoice?.ToString() ?? "No choice selected");
    }

}
