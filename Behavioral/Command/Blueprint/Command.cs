namespace Command.Blueprint;

public abstract class Command
{
    protected readonly Client _client;
    protected readonly Receiver _receiver;
    private string? BackupState { get; set; } = null;

    public Command(Client client, Receiver receiver)
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
