using Command.HanoiExample.Model;

namespace Command.HanoiExample.Command;

/// <summary>
/// A command that moves a <see cref="Disc"/> from one <see cref="Rod"/> to another.
/// </summary>
/// <param name="editor"><see cref="GameEditor"/> that allows for changes to be made to the <see cref="GameState"/>.</param>
/// <param name="sourceRod">The <see cref="Rod"/> to move the <see cref="Disc"/> from.</param>
/// <param name="destinationRod">The <see cref="Rod"/> to move the <see cref="Disc"/> to.</param>
public class MoveDiscCommand(GameEditor editor, RodPosition sourceRod, RodPosition destinationRod) : ICommand
{
    /// <summary>
    /// Moves a <see cref="Disc"/> from one <see cref="Rod"/> to another.
    /// </summary>
    public void Execute()
    {
        editor.MoveDisc(sourceRod, destinationRod);
    }

    /// <summary>
    /// Moves the previously moved <see cref="Disc"/> back.
    /// </summary>
    public void Undo()
    {
        editor.MoveDisc(destinationRod, sourceRod);
    }
}
