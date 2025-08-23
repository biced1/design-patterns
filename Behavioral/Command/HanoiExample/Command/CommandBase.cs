namespace Command.HanoiExample.Command;

public abstract class CommandBase(GameEditor editor, Application application)
{
    protected readonly GameEditor _editor = editor;
    protected readonly Application _application = application;

    public abstract void Execute();
}
