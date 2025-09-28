namespace Command.HanoiExample.Command;

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
