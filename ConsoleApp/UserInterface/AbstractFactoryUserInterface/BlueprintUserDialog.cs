using AbstractFactory.Blueprint;
using ConsoleApp.Extensions;
using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface.AbstractFactoryUserInterface;

public class BlueprintUserDialog(IConsole console, UserDialogBase previousDialog) : UserDialogBase(console, previousDialog)
{
    public override string DisplayName => "Blueprint";

    /// <inheritdoc />
    public override void Run()
    {
        var factories = new List<IAbstractFactory> {
            new ConcreteFactory1(),
            new ConcreteFactory2()
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
                var productA = factories[userInput.Input - 1 ?? 0].CreateProductA();
                var productB = factories[userInput.Input - 1 ?? 0].CreateProductB();
                _console.WriteLine($"Created products {productA.GetType().Name} and {productB.GetType().Name}");
            }
        }
    }
}