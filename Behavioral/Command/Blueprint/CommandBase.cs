namespace Command.Blueprint;

public abstract class CommandBase
{
    protected readonly Client _client;
    protected readonly Receiver _receiver;
    private string? BackupState { get; set; } = null;

    public CommandBase(Client client, Receiver receiver)
    {
        _client = client;
        _receiver = receiver;
    }

    public void Undo()
    {
        _receiver.SetState(BackupState);
    }

    protected void SaveState()
    {
        BackupState = _receiver.GetState();
    }

    public abstract void Execute();
}
