
namespace Command.Blueprint;

public class Command1 : CommandBase
{
    public Command1(Client client, Receiver receiver) : base(client, receiver)
    {
    }

    /// <summary>
    /// Command that appends the last pressed character to the current state.
    /// </summary>
    public override void Execute()
    {
        SaveState();
        var characterToAppend = _client.PressedCharacter;
        _receiver.AppendState(characterToAppend.ToString());
    }
}
