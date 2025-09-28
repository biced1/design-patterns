namespace Command.HanoiExample.Command;

/// <summary>
/// A command that performs functionality on the <see cref="GameEditor"/>
/// </summary>
public interface ICommand
{
    /// <summary>
    /// Execute the command
    /// </summary>
    public abstract void Execute();

    /// <summary>
    /// Undo the command
    /// </summary>
    public abstract void Undo();
}
