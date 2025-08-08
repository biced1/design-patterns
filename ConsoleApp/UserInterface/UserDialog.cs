using ConsoleApp.UserInterface.AbstractFactoryUserInterface;
using ConsoleApp.UserInterface.AdapterUserInterface;
using ConsoleApp.UserInterface.CommandUserInterface;
using ConsoleApp.UserInterface.FactoryUserInterface;
using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface;

/// <summary>
/// The top level menu of the application that allows users to choose a design pattern to explore.
/// </summary>
/// <param name="console"><see cref="IConsole"/> used to interact with the console.</param>
/// <param name="previousDialog">The most recent <see cref="UserDialogBase"/> that was ran, to allow the user to navigate back in dialog options.</param>
public class UserDialog(IConsole console, UserDialogBase? previousDialog) : UserDialogBase(console, previousDialog)
{
    /// <inheritdoc />
    public override string DisplayName => "Main Menu";

    /// <inheritdoc />
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
