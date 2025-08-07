namespace Command.Blueprint;

public class Command2 : CommandBase
{
    public Command2(Client client, Receiver receiver) : base(client, receiver)
    {
    }

    /// <summary>
    /// Command that deletes the last character from the current state.
    /// </summary>
    public override void Execute()
    {
        SaveState();
        var state = _receiver.GetState();
        if (!string.IsNullOrEmpty(state))
        {
            _receiver.SetState(state[..^1]);
        }
    }
}
