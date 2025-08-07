using ConsoleApp.Extensions;
using ConsoleApp.Wrapper;
using Factory.Blueprint;

namespace ConsoleApp.UserInterface.FactoryUserInterface;

public class BlueprintUserDialog(IConsole console, UserDialogBase previousDialog) : UserDialogBase(console, previousDialog)
{
    public override string DisplayName => "Blueprint";

    /// <inheritdoc />
    public override void Run()
    {
        var factories = new List<IFactory> {
            new FactoryA(),
            new FactoryB()
        };

        var userInput = new UserInput<int?>();
        while (!userInput.ShouldGoBack)
        {
            _console.WriteLine("Which factory would you like to test?");
            _console.ListItems([.. factories.Select(x => x.GetType().Name)]);
            userInput = _console.GetIntInput(1, factories.Count);
            if (userInput.ShouldGoBack)
            {
                GoBack();
            }
            else
            {
                var product = factories[userInput.Input - 1 ?? 0].CreateProduct();
                _console.WriteLine("Created product " + product.Nickname);
            }
        }
    }
}
