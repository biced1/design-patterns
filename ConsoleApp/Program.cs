using ConsoleHelper;
using DesignPatterns.UserInterface;

public class Program
{
    public static void Main()
    {
        new UserDialog(new ConsoleWrapper(), null).Run();
    }

}
