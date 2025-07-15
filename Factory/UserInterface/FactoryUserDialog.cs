using DesignPatterns.Factory.Blueprint;
using DesignPatterns.ConsoleHelper;

namespace DesignPatterns.Factory.UserInterface;

//TODO: Probably remove this. 
//I don't know that a navigatable dialog is actually useful to showcase these patterns
public class FactoryUserDialog : IUserDialog
{
    public void Run()
    {

        var factories = new List<IFactory> {
            new FactoryA(),
            new FactoryB()
        };

        Console.WriteLine("Welcome to the factory pattern.");

        Console.WriteLine("Which factory would you like to test?");
        for (int x = 0; x < factories.Count; x++)
        {
            Console.WriteLine($"{x + 1}: {factories[x].GetType().Name}");
        }
        var factoryNumber = Console.ReadLine();
    }
}