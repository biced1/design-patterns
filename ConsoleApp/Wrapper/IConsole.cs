namespace ConsoleApp.Wrapper;

/// <summary>
/// Represents the standard input, output, and error streams for console applications. This class cannot be inherited.
/// Wraps the standard input to allow for unit testing.
/// </summary>
public interface IConsole
{
    /// <summary>
    /// Writes the specified string value to the standard output stream.
    /// </summary>
    /// <param name="message">The message to write.</param>    void Write(string message);
    void Write(string message);

    /// <summary>
    /// Writes the specified string value, followed by the current line terminator, to the standard output stream.
    /// </summary>
    /// <param name="message">The message to write.</param>
    void WriteLine(string message);

    /// <summary>
    /// Writes the text representation of the specified 32-bit signed integer value to the standard output stream.
    /// </summary>
    /// <param name="message">The message to write.</param>
    void Write(int message);

    /// <summary>
    /// Writes the text representation of the specified 32-bit signed integer value, followed by the current line terminator, to the standard output stream.
    /// </summary>
    /// <param name="message">The message to write.</param>
    void WriteLine(int message);

    /// <summary>
    /// Reads the next line of characters from the input stream, or null if no more lines are available.
    /// </summary>
    /// <returns>The next line of characters from the input stream, or null if no more lines are available.</returns>
    string? ReadLine();
}