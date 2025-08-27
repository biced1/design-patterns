using Command.HanoiExample.Model;

namespace Command.HanoiExample.Command;

public class MoveDiscCommand(GameEditor editor, RodPosition sourceRod, RodPosition destinationRod) : ICommand
{
    public void Execute()
    {
        editor.MoveDisc(sourceRod, destinationRod);
    }
}
