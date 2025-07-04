namespace DesignPatterns.ConsoleHelper;

public class ConsoleWrapper : IConsole
{
    public void Write(string message)
    {
        Console.Write(message);
    }

    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }

    public void Write(int message)
    {
        Console.Write(message);
    }

    public void WriteLine(int message)
    {
        Console.WriteLine(message);
    }

    public string? ReadLine()
    {
        return Console.ReadLine();
    }
}