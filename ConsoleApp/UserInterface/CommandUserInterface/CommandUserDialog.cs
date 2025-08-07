using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface.CommandUserInterface;

/// <summary>
/// Dialog that displays options for the Command Pattern
/// </summary>
/// <param name="console"><see cref="IConsole"/> used to interact with the console.</param>
/// <param name="previousDialog">The most recent <see cref="UserDialogBase"/> that was ran, to allow the user to navigate back in dialog options.</param>
public class CommandUserDialog(IConsole console, UserDialogBase? previousDialog) : UserDialogBase(console, previousDialog)
{
    /// <inheritdoc />
    public override string DisplayName => "Command";

    /// <inheritdoc />
    public override void Run()
    {
        var options = new List<UserDialogBase> {
            new BlueprintUserDialog(_console, this)
        };

        RunSelectedPattern(options, "Welcome, what example of the Command Pattern would you like to explore?");
    }
}
