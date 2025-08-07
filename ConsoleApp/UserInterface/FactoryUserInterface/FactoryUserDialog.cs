using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface.FactoryUserInterface;

public class FactoryUserDialog(IConsole console, UserDialogBase previousDialog) : UserDialogBase(console, previousDialog)
{
    public override string DisplayName => "Factory";

    public override void Run()
    {
        var options = new List<UserDialogBase> {
            new BlueprintUserDialog(_console, this),
            new AuthenticationUserDialog(_console, this)
        };

        RunSelectedPattern(options, "Welcome, what example of the Factory Pattern would you like to explore?");
    }
}