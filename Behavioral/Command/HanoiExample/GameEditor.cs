using Command.HanoiExample.Model;

namespace Command.HanoiExample;

public class GameEditor
{
    public GameState GameState { get; private set; } = new GameState(new Rod(RodPosition.Left), new Rod(RodPosition.Middle), new Rod(RodPosition.Right));

    public void NewGame(uint numberOfDiscs)
    {
        GameState = new GameState(new Rod(RodPosition.Left, numberOfDiscs), new Rod(RodPosition.Middle), new Rod(RodPosition.Right));
    }

    public void MoveDisc(RodPosition sourceRod, RodPosition destinationRod)
    {
        var source = GetRod(sourceRod);
        var destination = GetRod(destinationRod);
        if (CanMoveDisc(source, destination))
        {
            var discToMove = source.Discs.Pop();
            destination.Discs.Push(discToMove);
        }
    }

    public bool CanMoveDisc(RodPosition sourceRod, RodPosition destinationRod)
    {
        var source = GetRod(sourceRod);
        var destination = GetRod(destinationRod);
        return CanMoveDisc(source, destination);
    }

    private bool CanMoveDisc(Rod source, Rod destination)
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
