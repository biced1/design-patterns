using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface.AbstractFactoryUserInterface;

/// <summary>
/// Dialog that displays options for the Abstract Factory Pattern
/// </summary>
/// <param name="console"><see cref="IConsole"/> used to interact with the console.</param>
/// <param name="previousDialog">The most recent <see cref="UserDialogBase"/> that was ran, to allow the user to navigate back in dialog options.</param>
public class AbstractFactoryUserDialog(IConsole console, UserDialogBase previousDialog) : UserDialogBase(console, previousDialog)
{
    /// <inheritdoc />
    public override string DisplayName => "Abstract Factory";

    /// <inheritdoc />
    public override void Run()
    {
        var options = new List<UserDialogBase> {
            new BlueprintUserDialog(_console, this),
            new CarExampleUserDialog(_console, this)
        };

        RunSelectedPattern(options, "Welcome, what example of the Abstract Factory Pattern would you like to explore?");
    }
}
