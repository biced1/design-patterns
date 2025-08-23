using Command.HanoiExample.Model;

namespace Command.HanoiExample;

public class GameEditor
{
    public GameState GameState { get; set; } = new GameState(new Rod(), new Rod(), new Rod());

    public void NewGame(uint numberOfDiscs)
    {
        GameState = new GameState(new Rod(numberOfDiscs), new Rod(), new Rod());
    }
}
