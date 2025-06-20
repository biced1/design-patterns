using DesignPatterns.ConsoleHelper;
using DesignPatterns.Factory.UserInterface;

namespace DesignPatterns.UserInterface;

public static class UserDialog
{
    public static void Run(IConsole console)
    {
        var options = new List<IUserDialog>
        {
            new FactoryUserDialog()
        };

        int? factoryChoice = null;

        while (factoryChoice == null)
        {
            console.WriteLine("Welcome to Design Patterns.");
            var message = "What kind of design pattern would you like to test?\n";

            for (int x = 0; x < options.Count; x++)
            {
                message += $"{x + 1}: {options[x].GetType().Name}\n";
            }
            factoryChoice = InputHelper.GetIntInput(console, message, 1, options.Count);
        }

        options[(factoryChoice ?? 1) - 1].Run();
    }

}
