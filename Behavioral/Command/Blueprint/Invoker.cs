namespace Command.Blueprint;

/// <summary>
/// Class responsible for invoking or sending commands.
/// Generally there will be more than one Invoker that needs to perform the same command.
/// </summary>
public class Invoker
{
    private CommandBase? _command;
    public void SetCommand(CommandBase command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        _command?.Execute();
    }
}
