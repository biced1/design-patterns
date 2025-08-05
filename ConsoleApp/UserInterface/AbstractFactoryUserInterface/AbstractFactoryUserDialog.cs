using ConsoleHelper;

namespace ConsoleApp.UserInterface.AbstractFactoryUserInterface;

public class AbstractFactoryUserDialog : UserDialogBase
{
    public AbstractFactoryUserDialog(IConsole console, UserDialogBase previousDialog) : base(console, previousDialog)
    { }

    public override string DisplayName => "Abstract Factory";

    public override void Run()
    {
        var options = new List<UserDialogBase> {
            new BlueprintUserDialog(_console, this),
            new CarExampleUserDialog(_console, this)
        };

        _console.WriteLine("Welcome, what example of the Factory Pattern would you like to explore?");
        _console.ListItems([.. options.Select(x => x.DisplayName)]);
        var option = _console.GetIntInput(1, options.Count);
        if (option.ShouldGoBack)
        {
            GoBack();
        }

        options[option.UserInput - 1 ?? 0].Run();
    }
}
