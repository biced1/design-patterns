using Command.HanoiExample.Command;

namespace Command.HanoiExample;

public class DiscControl
{
    private CommandBase? command;

    public void SetCommand(CommandBase command) {
        this.command = command;
    }

    public void MoveDiscs() {
        command?.Execute();
    }

}
