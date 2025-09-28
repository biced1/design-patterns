using Command.HanoiExample.Command;

namespace Command.HanoiExample;

/// <summary>
/// A service that handles user input by executing commands.
/// </summary>
public class InputHandler
{
    private ICommand? command;

    /// <summary>
    /// Sets the current <see cref="ICommand"/> to be run.
    /// </summary>
    /// <param name="command">The current <see cref="ICommand"/> to be run.</param>
    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    /// <summary>
    /// Handles user input by executing the current <see cref="ICommand"/>.
    /// </summary>
    public void HandleInput()
    {
        command?.Execute();
    }
}
