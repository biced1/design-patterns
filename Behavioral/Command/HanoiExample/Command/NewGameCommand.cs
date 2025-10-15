using Command.HanoiExample.Model;

namespace Command.HanoiExample.Command;

/// <summary>
/// A command that creates sets up a new Towers of Hanoi game.
/// </summary>
/// <param name="editor"><see cref="GameEditor"/> that allows for changes to be made to the <see cref="GameState"/>.</param>
/// <param name="numberOfDiscs">The number of discs to use for this game.</param>
public class NewGameCommand(GameEditor editor, uint numberOfDiscs) : ICommand
{
    /// <summary>
    /// Sets the specified number of discs up on the left <see cref="Rod"/> of the <see cref="GameState"/>
    /// </summary>
    public void Execute()
    {
        editor.NewGame(numberOfDiscs);
    }

    /// <summary>
    /// Not valid as there is no need to delete starting game state
    /// </summary>
    /// <exception cref="InvalidOperationException "></exception>
    public void Undo()
    {
        throw new InvalidOperationException();
    }
}
