using Command.HanoiExample.Model;

namespace Command.HanoiExample.Command;

/// <summary>
/// A command that creates sets up a new Towers of Hanoi game.
/// </summary>
/// <param name="editor"><see cref="GameEditor"/> that allows for changes to be made to the <see cref="GameState"/>.</param>
/// <param name="numberOfDiscs">The number of discs to use for this game.</param>
public class NewGameCommand(GameEditor editor, uint numberOfDiscs) : ICommand
{
    private readonly GameEditor _editor = editor;
    private readonly uint _numberOfDiscs = numberOfDiscs;

    /// <summary>
    /// Sets the specified number of discs up on the left <see cref="Rod"/> of the <see cref="GameState"/>
    /// </summary>
    public void Execute()
    {
        _editor.NewGame(_numberOfDiscs);
    }

    /// <summary>
    /// Not implemented as there is no need to delete starting game state
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void Undo()
    {
        throw new NotImplementedException();
    }
}
