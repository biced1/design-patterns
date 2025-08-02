namespace Command.Blueprint;

/// <summary>
/// The class that allows actions to be performed on the application.
/// </summary>
public class Client
{
    private Stack<Command> _commandHistory = new Stack<Command>();
    private readonly Invoker _invoker;

    private readonly Command _command1;
    private readonly Command _command2;

    public char PressedCharacter { get; private set; }

    public Client(Receiver receiver, Invoker invoker)
    {
        _invoker = invoker;

        _command1 = new Command1(this, receiver);
        _command2 = new Command2(this, receiver);
    }

    public void ExecuteCommand1( char character)
    {
        PressedCharacter = character;
        ExecuteCommand(_command1);
    }

    public void ExecuteCommand2()
    {
        ExecuteCommand(_command2);
    }

    /// <summary>
    /// Undoes the last command executed.
    /// Can be run until all commands have been undone.
    /// Optional part of the command pattern, but a common part of the implementation.
    /// </summary>
    public void Undo()
    {
        var command = _commandHistory.Pop();
        command?.Undo();
    }

    private void ExecuteCommand(Command command)
    {
        _invoker.SetCommand(command);
        _invoker.ExecuteCommand();
        _commandHistory.Push(command);
    }
}
