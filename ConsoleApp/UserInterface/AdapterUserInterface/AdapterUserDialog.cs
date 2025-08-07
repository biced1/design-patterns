using ConsoleHelper;

namespace ConsoleApp.UserInterface.AdapterUserInterface;

public class AdapterUserDialog : UserDialogBase
{
    public AdapterUserDialog(IConsole console, UserDialogBase previousDialog) : base(console, previousDialog)
    { }

    public override string DisplayName => "Adapter";

    public override void Run()
    {
        var options = new List<UserDialogBase> {
            new BlueprintUserDialog(_console, this),
            new CalculatorExampleUserDialog(_console, this)
        };

        _console.WriteLine("Welcome, what example of the Adapter Pattern would you like to explore?");
        _console.ListItems([.. options.Select(x => x.DisplayName)]);
        var option = _console.GetIntInput(1, options.Count);
        if (option.ShouldGoBack)
        {
            GoBack();
        }

        options[option.UserInput - 1 ?? 0].Run();
    }
}
