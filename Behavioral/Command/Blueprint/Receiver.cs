namespace Command.Blueprint;

/// <summary>
/// The class that stores the current state of the application and allows for changes to be applied.
/// </summary>
public class Receiver
{
    private string? _state;

    public string? GetState()
    {
        return _state;
    }

    public void SetState(string? newState)
    {
        _state = newState;
    }

    public void AppendState(string appendState)
    {
        _state += appendState;
    }
}
