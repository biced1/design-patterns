using Command.HanoiExample.Model;

namespace Command.HanoiExample;

public class GameEditor
{
    public GameState GameState { get; set; } = new GameState(new Rod(RodPosition.Left), new Rod(RodPosition.Middle), new Rod(RodPosition.Right));

    public void NewGame(uint numberOfDiscs)
    {
        GameState = new GameState(new Rod(RodPosition.Left, numberOfDiscs), new Rod(RodPosition.Middle), new Rod(RodPosition.Right));
    }

    public void MoveDisc(RodPosition sourceRod, RodPosition destinationRod)
    {
        //validation
        var source = GetRod(sourceRod);
        var destination = GetRod(destinationRod);
        var discToMove = source.Discs.Pop();
        destination.Discs.Push(discToMove);
    }

    private Rod GetRod(RodPosition position) => position switch
    {
        RodPosition.Left => GameState.LeftRod,
        RodPosition.Middle => GameState.MiddleRod,
        RodPosition.Right => GameState.RightRod,
        _ => throw new NotImplementedException()
    };
}
