namespace Command.Blueprint;

/// <summary>
/// <see cref="CommandBase"/> that deletes the most recent pressed character to the receiver state.
/// </summary>
/// <param name="client">The <see cref="Client"/> that the user interacts with.</param>
/// <param name="receiver">The <see cref="Receiver"/> that manages the state.</param>
public class Command2(Client client, Receiver receiver) : CommandBase(client, receiver)
{

    /// <summary>
    /// <see cref="CommandBase"/> that deletes the last character from the current state.
    /// </summary>
    public override void Execute()
    {
        SaveState();
        var state = _receiver.State;
        if (!string.IsNullOrEmpty(state))
        {
            _receiver.State = state[..^1];
        }
    }
}
