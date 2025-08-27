using Command.HanoiExample.Command;

namespace Command.HanoiExample;

public class InputHandler
{
    private ICommand? command;

    public void SetCommand(ICommand command) {
        this.command = command;
    }

    public void HandleInput() {
        command?.Execute();
    }
}
