using AbstractFactory.CarExample;
using ConsoleApp.Extensions;
using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface.AbstractFactoryUserInterface;

/// <summary>
/// Dialog that lets the user try the car example for the Abstract Factory pattern.
/// </summary>
/// <param name="console"><see cref="IConsole"/> used to interact with the console.</param>
/// <param name="previousDialog">The most recent <see cref="UserDialogBase"/> that was ran, to allow the user to navigate back in dialog options.</param>
public class CarExampleUserDialog(IConsole console, UserDialogBase previousDialog) : UserDialogBase(console, previousDialog)
{
    /// <inheritdoc />
    public override string DisplayName => "Car Part Factory";

    /// <inheritdoc />
    public override void Run()
    {
        var carPartFactories = new List<ICarPartFactory> {
            new SubaruBrzCarPartFactory(),
            new VwGtiCarPartFactory()
        };

        var userInput = new UserInput<int?>();
        while (!userInput.ShouldGoBack)
        {
            _console.WriteLine("What car would you like to build parts for?");
            _console.ListItems([.. carPartFactories.Select(x => x.GetType().Name)]);
            userInput = _console.GetIntInput(1, carPartFactories.Count);
            if (userInput.ShouldGoBack)
            {
                GoBack();
            }
            else
            {
                var selectedFactory = carPartFactories[userInput.Input - 1 ?? 0];
                var cupHolder = selectedFactory.CreateCupHolder();
                var engine = selectedFactory.CreateEngine();
                var transmission = selectedFactory.CreateTransmission();
                _console.WriteLine("You built the following car parts.");
                _console.WriteLine($"A cup holder with {cupHolder.Capacity} spots for cups.");
                _console.WriteLine($"An engine with {engine.Cylinders} cylinders.");
                _console.WriteLine($"A transmission {transmission.Gears} gears.");
                _console.WriteLine($"These parts are all compatible with a {cupHolder.Make} {cupHolder.Model}");
            }
        }
    }
}
