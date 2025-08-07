using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface.AbstractFactoryUserInterface;

public class AbstractFactoryUserDialog(IConsole console, UserDialogBase previousDialog) : UserDialogBase(console, previousDialog)
{
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
