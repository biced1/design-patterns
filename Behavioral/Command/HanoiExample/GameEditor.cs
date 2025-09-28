using Command.HanoiExample.Model;

namespace Command.HanoiExample;

/// <summary>
/// Editor that allows changes to be made to the Towers of Hanoi <see cref="GameState"/>
/// </summary>
public class GameEditor
{
    public GameState GameState { get; private set; } = new GameState(new Rod(RodPosition.Left), new Rod(RodPosition.Middle), new Rod(RodPosition.Right));

    /// <summary>
    /// Creates a new game, with a stack of <see cref="Disc"/> on the left <see cref="Rod"/>.
    /// Functions that should only be accessible from commands, and not the application, should be internal.
    /// </summary>
    /// <param name="numberOfDiscs">The number of <see cref="Disc"/> to put on the left <see cref="Rod"/></param>
    internal void NewGame(uint numberOfDiscs)
    {
        GameState = new GameState(new Rod(RodPosition.Left, numberOfDiscs), new Rod(RodPosition.Middle), new Rod(RodPosition.Right));
    }

    /// <summary>
    /// Moves a <see cref="Disc"/> from one <see cref="Rod"/> to another.
    /// Functions that should only be accessible from commands, and not the application, should be internal.
    /// </summary>
    /// <param name="sourceRod">The <see cref="Rod"/> to move the <see cref="Disc"/> from.</param>
    /// <param name="destinationRod">The <see cref="Rod"/> to move the <see cref="Disc"/> to.</param>
    internal void MoveDisc(RodPosition sourceRod, RodPosition destinationRod)
    {
        var source = GetRod(sourceRod);
        var destination = GetRod(destinationRod);
        if (CanMoveDisc(source, destination))
        {
            var discToMove = source.Discs.Pop();
            destination.Discs.Push(discToMove);
        }
    }

    /// <summary>
    /// Adds a disc to the bottom of the left rod.
    /// Functions that should only be accessible from commands, and not the application, should be internal.
    /// </summary>
    internal void AddDisc()
    {
        GameState.LeftRod.AddDisc((uint)GameState.TotalDiscs + 1);
    }

    /// <summary>
    /// Determines if a <see cref="Disc"/> can be moved from one <see cref="Rod"/> to another.
    /// </summary>
    /// <param name="sourceRod">The <see cref="Rod"/> to move the <see cref="Disc"/> from.</param>
    /// <param name="destinationRod">The <see cref="Rod"/> to move the <see cref="Disc"/> to.</param>
    /// <returns>True if this is a legal move, false if it is not.</returns>
    public bool CanMoveDisc(RodPosition sourceRod, RodPosition destinationRod)
    {
        var source = GetRod(sourceRod);
        var destination = GetRod(destinationRod);
        return CanMoveDisc(source, destination);
    }

    /// <summary>
    /// Determines if the user has won the current Towers of Hanoi game.
    /// </summary>
    /// <returns>True if the user has won, false if they have lost.</returns>
    public bool HasWon()
    {
        return GameState.MiddleRod.Discs.Count == GameState.TotalDiscs
            || GameState.RightRod.Discs.Count == GameState.TotalDiscs;
    }

    private static bool CanMoveDisc(Rod source, Rod destination)
    {
        var canMove = true;
        if (source.Discs.Count == 0)
        {
            canMove = false;
        }
        else
        {
            var discToMove = source.Discs.Peek();
            if (destination.Discs.Count != 0)
            {
                var topDestinationDisc = destination.Discs.Peek();
                canMove = discToMove.Size < topDestinationDisc.Size;
            }
        }
        return canMove;
    }

    private Rod GetRod(RodPosition position) => position switch
    {
        RodPosition.Left => GameState.LeftRod,
        RodPosition.Middle => GameState.MiddleRod,
        RodPosition.Right => GameState.RightRod,
        _ => throw new NotImplementedException()
    };
}
