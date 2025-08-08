
namespace Command.Blueprint;

/// <summary>
/// <see cref="CommandBase"/> that appends the most recent pressed character to the receiver state.
/// </summary>
/// <param name="client">The <see cref="Client"/> that the user interacts with.</param>
/// <param name="receiver">The <see cref="Receiver"/> that manages the state.</param>
public class Command1(Client client, Receiver receiver) : CommandBase(client, receiver)
{
    /// <summary>
    /// <see cref="CommandBase"/> that appends the last pressed character to the current state.
    /// </summary>
    public override void Execute()
    {
        SaveState();
        var characterToAppend = _client.PressedCharacter;
        _receiver.AppendState(characterToAppend.ToString());
    }
}
