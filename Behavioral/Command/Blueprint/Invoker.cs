namespace Command.Blueprint;

/// <summary>
/// Class responsible for invoking or sending commands.
/// Generally there will be more than one Invoker that needs to perform the same command.
/// </summary>
public class Invoker
{
    private CommandBase? _command;

    /// <summary>
    /// Sets the next <see cref="CommandBase"/> to be run.
    /// </summary>
    /// <param name="command"><see cref="CommandBase"/> to be run.</param>
    public void SetCommand(CommandBase command)
    {
        _command = command;
    }

    /// <summary>
    /// Executes the most recently set <see cref="CommandBase"/>.
    /// </summary>
    public void ExecuteCommand()
    {
        _command?.Execute();
    }
}
