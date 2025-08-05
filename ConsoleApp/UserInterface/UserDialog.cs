using ConsoleApp.UserInterface.AbstractFactoryUserInterface;
using ConsoleApp.UserInterface.FactoryUserInterface;
using ConsoleHelper;

namespace DesignPatterns.UserInterface;

public class UserDialog : UserDialogBase
{
    public UserDialog(IConsole console, UserDialogBase? previousDialog) : base(console, previousDialog)
    { }

    public override string DisplayName => throw new NotImplementedException();

    public override void Run()
    {
        var options = new List<UserDialogBase>
        {
            new FactoryUserDialog(_console, this),
            new AbstractFactoryUserDialog(_console, this)
        };

        var userInput = new IntUserInput();

        _console.WriteLine("Welcome to Design Patterns.");
        _console.WriteLine("What kind of design pattern would you like to test?");

        _console.ListItems([.. options.Select(x => x.DisplayName)]);
        userInput = _console.GetIntInput(1, options.Count);
        if (userInput.ShouldGoBack)
        {
            GoBack();
        }

        options[(userInput.UserInput ?? 1) - 1].Run();
    }
}
