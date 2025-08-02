using Command.Blueprint;

namespace CommandTests;

public class CommandTests
{
    private readonly Receiver _receiver;
    private readonly Invoker _invoker;
    private readonly Client _client;

    public CommandTests()
    {
        _receiver = new Receiver();
        _invoker = new Invoker();
        _client = new Client(_receiver, _invoker);
    }

    [Fact]
    public void ExecuteCommand1_AppendsCorrectCharacter()
    {
        _receiver.SetState("");

        _client.ExecuteCommand1('t');

        Assert.Equal("t", _receiver.GetState());
    }

    [Fact]
    public void ExecuteCommand2_RemovesEndCharacter()
    {
        _receiver.SetState("Test");

        _client.ExecuteCommand2();

        Assert.Equal("Tes", _receiver.GetState());
    }
}