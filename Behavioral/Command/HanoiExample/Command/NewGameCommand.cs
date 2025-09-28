namespace Command.HanoiExample.Command;

public class NewGameCommand(GameEditor editor, uint numberOfDiscs) : ICommand
{
    private readonly GameEditor _editor = editor;
    private readonly uint _numberOfDiscs = numberOfDiscs;

    /// <inheritdoc/>
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
