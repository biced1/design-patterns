using Command.HanoiExample;
using Command.HanoiExample.Model;

namespace CommandTests.HanoiExample;

public class GameEditorTests
{
    private readonly GameEditor _gameEditor;

    public GameEditorTests()
    {
        _gameEditor = new GameEditor();
    }

    [Fact]
    public void NewGame_CreatesGameSuccessfully()
    {
        _gameEditor.NewGame(8);

        Assert.Equal(8, _gameEditor.GameState.LeftRod.Discs.Count);
        Assert.Empty(_gameEditor.GameState.MiddleRod.Discs);
        Assert.Empty(_gameEditor.GameState.RightRod.Discs);
    }

    [Fact]
    public void CanMoveDisc_ReturnsTrue_WhenMovingToEmptyRod()
    {
        _gameEditor.NewGame(8);
        var canMove = _gameEditor.CanMoveDisc(RodPosition.Left, RodPosition.Middle);

        Assert.True(canMove);
    }

    [Fact]
    public void CanMoveDisc_ReturnsFalse_WhenMovingLargerDiscOntoSmaller()
    {
        _gameEditor.NewGame(8);
        _gameEditor.MoveDisc(RodPosition.Left, RodPosition.Middle);
        var canMove = _gameEditor.CanMoveDisc(RodPosition.Left, RodPosition.Middle);

        Assert.False(canMove);
    }

    [Fact]
    public void MoveDisc_MovesDisc()
    {
        _gameEditor.NewGame(8);
        _gameEditor.MoveDisc(RodPosition.Left, RodPosition.Middle);

        Assert.Equal(7, _gameEditor.GameState.LeftRod.Discs.Count);
        Assert.Single(_gameEditor.GameState.MiddleRod.Discs);
    }

        [Fact]
    public void MoveDisc_DoesntMove_IfInvalid()
    {
        _gameEditor.NewGame(8);
        _gameEditor.MoveDisc(RodPosition.Left, RodPosition.Middle);
        _gameEditor.MoveDisc(RodPosition.Left, RodPosition.Middle);

        Assert.Equal(7, _gameEditor.GameState.LeftRod.Discs.Count);
        Assert.Single(_gameEditor.GameState.MiddleRod.Discs);
    }
}
