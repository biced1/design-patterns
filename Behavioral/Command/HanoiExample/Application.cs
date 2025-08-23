using Command.HanoiExample.Command;
using Command.HanoiExample.Model;

namespace Command.HanoiExample;

public class Application
{
    private readonly Stack<CommandBase> commandHistory;
    private readonly GameEditor editor;
    private readonly DiscControl discControl;
    private readonly MoveDiscCommand moveDiscCommand;
    private readonly NewGameCommand newGameCommand;

    public uint NumberOfDiscs { get; private set; }

    public Application()
    {
        commandHistory = new();
        editor = new();
        discControl = new();
        moveDiscCommand = new(editor, this);
        newGameCommand = new(editor, this);
    }
    
    public GameState GetGameState() => editor.GameState;

    public void NewGame(int discs = 6)
    {
        //validate more than 6 discs
        NumberOfDiscs = (uint)discs;

        discControl.SetCommand(newGameCommand);
        discControl.MoveDiscs();
    }

}
