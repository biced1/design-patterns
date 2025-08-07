namespace Command.Blueprint;

/// <summary>
/// The class that allows actions to be performed on the application.
/// </summary>
public class Client
{
    private Stack<CommandBase> _commandHistory = new Stack<CommandBase>();
    private readonly Invoker _invoker;
    private readonly Receiver _receiver;

    public char PressedCharacter { get; private set; }

    public Client(Receiver receiver, Invoker invoker)
    {
        _invoker = invoker;
        _receiver = receiver;

    }

    public void ExecuteCommand1(char character)
    {
        PressedCharacter = character;
        ExecuteCommand(new Command1(this, _receiver));
    }

    public void ExecuteCommand2()
    {
        ExecuteCommand(new Command2(this, _receiver));
    }

    /// <summary>
    /// Undoes the last command executed.
    /// Can be run until all commands have been undone.
    /// Optional part of the command pattern, but a common part of the implementation.
    /// </summary>
    public void Undo()
    {
        if (_commandHistory.Any())
        {
            var command = _commandHistory.Pop();
            command.Undo();
        }
    }

    private void ExecuteCommand(CommandBase command)
    {
        _invoker.SetCommand(command);
        _invoker.ExecuteCommand();
        _commandHistory.Push(command);
    }
}
