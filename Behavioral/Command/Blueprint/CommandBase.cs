namespace Command.Blueprint;

/// <summary>
/// The basis for a command. Contains abstract functions to be implemented and implementations of shared logic.
/// </summary>
/// <param name="client">The <see cref="Client"/> that the user interacts with.</param>
/// <param name="receiver">The <see cref="Receiver"/> that manages the state.</param>
public abstract class CommandBase(Client client, Receiver receiver)
{
    protected readonly Client _client = client;
    protected readonly Receiver _receiver = receiver;
    private string? BackupState { get; set; } = null;

    /// <summary>
    /// Undoes the action performed by this <see cref="CommandBase"/>.
    /// </summary>
    public void Undo()
    {
        _receiver.State = BackupState;
    }

    protected void SaveState()
    {
        BackupState = _receiver.State;
    }

    /// <summary>
    /// Executes the action of this <see cref="CommandBase"/>
    /// </summary>
    public abstract void Execute();
}
