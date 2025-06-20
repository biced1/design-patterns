using DesignPatterns.Factory.Blueprint;

namespace DesignPatterns.Factory.UserInterface;

public class FactoryUserDialog
{
    public void Run() {
        
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