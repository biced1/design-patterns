using DesignPatterns.ConsoleHelper;
using DesignPatterns.UserInterface;

public class Program
{
    public static void Main()
    {

        UserDialog.Run(new ConsoleWrapper());
    }

}
