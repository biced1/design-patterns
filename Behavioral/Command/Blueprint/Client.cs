namespace Command.Blueprint;

/// <summary>
/// The class that allows <see cref="CommandBase"/>'s to be performed on the <see cref="Receiver"/>.
/// In this example, it appends or deletes characters from a string.
/// You can replace this logic with whatever logic makes sense for your application.
/// </summary>
public class Client(Receiver receiver, Invoker invoker)
{
    private Stack<CommandBase> _commandHistory = new();
    private readonly Invoker _invoker = invoker;
    private readonly Receiver _receiver = receiver;

    /// <summary>
    /// The most recently pressed character.
    /// </summary>
    public char PressedCharacter { get; private set; }

    /// <summary>
    /// Executes Command1, a <see cref="CommandBase"/> that appends a character to the <see cref="Receiver"/> state.
    /// The command pattern revolves around these commands.
    /// You can have as many as you need to fulfill requirements.
    /// </summary>
    /// <param name="character">The character to append to the <see cref="Receiver"/.</param>
    public void ExecuteCommand1(char character)
    {
        PressedCharacter = character;
        ExecuteCommand(new Command1(this, _receiver));
    }

    /// <summary>
    /// Executes Command2, a <see cref="CommandBase"/> that deletes the last character on the <see cref="Receiver"/ state.
    /// </summary>
    public void ExecuteCommand2()
    {
        ExecuteCommand(new Command2(this, _receiver));
    }

    /// <summary>
    /// Undoes the last <see cref="CommandBase"/> executed.
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
