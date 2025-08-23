namespace Command.HanoiExample.Command;

public class NewGameCommand(GameEditor editor, Application application) : CommandBase(editor, application)
{
    public override void Execute()
    {
        _editor.NewGame(_application.NumberOfDiscs);
    }
}
