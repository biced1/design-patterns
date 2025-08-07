namespace ConsoleApp.Wrapper;

/// <inheritdoc />
public class ConsoleWrapper : IConsole
{
    /// <inheritdoc />
    public void Write(string message)
    {
        Console.Write(message);
    }

    /// <inheritdoc />
    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }

    /// <inheritdoc />
    public void Write(int message)
    {
        Console.Write(message);
    }

    /// <inheritdoc />
    public void WriteLine(int message)
    {
        Console.WriteLine(message);
    }

    /// <inheritdoc />
    public string? ReadLine()
    {
        return Console.ReadLine();
    }
}