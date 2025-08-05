using ConsoleHelper;
using DesignPatterns.Factory.Blueprint;

namespace ConsoleApp.UserInterface.FactoryUserInterface;

public class BlueprintUserDialog : UserDialogBase
{
    public BlueprintUserDialog(IConsole console, UserDialogBase previousDialog) : base(console, previousDialog)
    {}

    public override string DisplayName => "Blueprint";

    public override void Run()
    {
        var factories = new List<IFactory> {
            new FactoryA(),
            new FactoryB()
        };

        var keepGoing = true;
        while (keepGoing)
        {
            _console.WriteLine("Which factory would you like to test?");
            _console.ListItems([.. factories.Select(x => x.GetType().Name)]);
            var userInput = _console.GetIntInput(1, factories.Count);
            if (userInput.ShouldGoBack)
            {
                keepGoing = false;
                GoBack();
            }
            else
            {
                var product = factories[userInput.UserInput - 1 ?? 0].CreateProduct();
                _console.WriteLine("Created product " + product.Nickname);
            }
        }
    }
}
