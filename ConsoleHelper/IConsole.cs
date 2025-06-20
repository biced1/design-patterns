namespace DesignPatterns.ConsoleHelper;

public interface IConsole
{
    void Write(string message);
    void WriteLine(string message);
    void Write(int message);
    void WriteLine(int message);
    string? ReadLine();
}