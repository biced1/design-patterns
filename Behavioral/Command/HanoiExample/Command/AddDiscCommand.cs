using Command.HanoiExample.Model;

namespace Command.HanoiExample.Command;

/// <summary>
/// A command that adds a <see cref="Disc"/>  to the left <see cref="Rod"/> .
/// </summary>
/// <param name="editor"></param>
public class AddDiscCommand(GameEditor editor) : ICommand
{
    /// <summary>
    /// Adds a <see cref="Disc"/>  to the left <see cref="Rod"/> .
    /// </summary>
    public void Execute()
    {
        editor.AddDisc();
    }

    /// <summary>
    /// Not valid, as there is no reason to undo this command.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public void Undo()
    {
        throw new InvalidOperationException();
    }
}
