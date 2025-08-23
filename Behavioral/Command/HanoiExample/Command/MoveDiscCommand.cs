using System;

namespace Command.HanoiExample.Command;

public class MoveDiscCommand(GameEditor editor, Application application) : CommandBase(editor, application)
{
    public override void Execute()
    {
        throw new NotImplementedException();
    }
}
