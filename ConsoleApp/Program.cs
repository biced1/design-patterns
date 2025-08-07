using ConsoleApp.UserInterface;
using ConsoleHelper;

public class Program
{
    public static void Main()
    {
        new UserDialog(new ConsoleWrapper(), null).Run();
    }

}
