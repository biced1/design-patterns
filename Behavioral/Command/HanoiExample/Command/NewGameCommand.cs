namespace Command.HanoiExample.Command;

public class NewGameCommand(GameEditor editor, uint numberOfDiscs) : ICommand
{
    private readonly GameEditor _editor = editor;
    private readonly uint _numberOfDiscs = numberOfDiscs;

    public void Execute()
    {
        _editor.NewGame(_numberOfDiscs);
    }
}
