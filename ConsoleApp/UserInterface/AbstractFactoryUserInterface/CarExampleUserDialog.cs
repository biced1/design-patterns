using AbstractFactory.CarExample;
using ConsoleApp.Extensions;
using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface.AbstractFactoryUserInterface;

public class CarExampleUserDialog(IConsole console, UserDialogBase previousDialog) : UserDialogBase(console, previousDialog)
{
    public override string DisplayName => "Car Part Factory";

    public override void Run()
    {
        var carPartFactories = new List<ICarPartFactory> {
            new SubaruBrzCarPartFactory(),
            new VwGtiCarPartFactory()
        };

        var userInput = new IntUserInput();
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
                var cupHolder = carPartFactories[userInput.UserInput - 1 ?? 0].CreateCupHolder();
                var engine = carPartFactories[userInput.UserInput - 1 ?? 0].CreateEngine();
                var transmission = carPartFactories[userInput.UserInput - 1 ?? 0].CreateTransmission();
                _console.WriteLine("You built the following car parts.");
                _console.WriteLine($"A cup holder with {cupHolder.Capacity} spots for cups.");
                _console.WriteLine($"An engine with {engine.Cylinders} cylinders.");
                _console.WriteLine($"A transmission {transmission.Gears} gears.");
                _console.WriteLine($"These parts are all compatible with a {cupHolder.Make} {cupHolder.Model}");
            }
        }
    }
}
