using ConsoleHelper;

namespace ConsoleApp.UserInterface.CommandUserInterface;

public class CommandUserDialog : UserDialogBase
{
    public CommandUserDialog(IConsole console, UserDialogBase? previousDialog) : base(console, previousDialog)
    { }

    public override string DisplayName => "Command";

    public override void Run()
    {
        var options = new List<UserDialogBase> {
            new BlueprintUserDialog(_console, this)
        };

        RunSelectedPattern(options, "Welcome, what example of the Command Pattern would you like to explore?");
    }
}
