namespace Command.Blueprint;

/// <summary>
/// The class that stores the current state of the application and allows for changes to be applied.
/// </summary>
public class Receiver
{
    /// <summary>
    /// Represents the current state of the application.
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Appends the given string to the end of the current state.
    /// </summary>
    /// <param name="appendState">The string to append to the current state.</param>
    public void AppendState(string appendState)
    {
        State += appendState;
    }
}
