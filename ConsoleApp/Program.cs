
using ConsoleApp.UserInterface;
using ConsoleApp.Wrapper;

public class Program
{
    public static void Main()
    {
        new UserDialog(new ConsoleWrapper(), null).Run();
    }

}
