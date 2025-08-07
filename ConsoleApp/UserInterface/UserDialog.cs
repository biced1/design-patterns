using ConsoleApp.UserInterface.AbstractFactoryUserInterface;
using ConsoleApp.UserInterface.AdapterUserInterface;
using ConsoleApp.UserInterface.CommandUserInterface;
using ConsoleApp.UserInterface.FactoryUserInterface;
using ConsoleHelper;

namespace ConsoleApp.UserInterface;

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
            new AbstractFactoryUserDialog(_console, this),
            new AdapterUserDialog(_console, this),
            new CommandUserDialog(_console, this)
        };

        _console.WriteLine("Welcome to Design Patterns.");
        RunSelectedPattern(options, "What kind of design pattern would you like to test?");
    }
}
