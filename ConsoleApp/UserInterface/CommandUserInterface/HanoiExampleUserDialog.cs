using System.Text;
using Command.HanoiExample;
using Command.HanoiExample.Command;
using Command.HanoiExample.Model;
using ConsoleApp.Extensions;
using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface.CommandUserInterface;

public class HanoiExampleUserDialog(IConsole console, UserDialogBase? previousDialog) : UserDialogBase(console, previousDialog)
{
    public override string DisplayName => "Towers of Hanoi Game";

    public override void Run()
    {
        var gameEditor = new GameEditor();
        var inputHandler = new InputHandler();
        inputHandler.SetCommand(new NewGameCommand(gameEditor, 6));
        inputHandler.HandleInput();
        DisplayGameState(gameEditor.GameState);

        while (true)
        {
            //ask the user what move they would like to make
            _console.WriteLine("Which rod would you like to move a disc from?");
            var options = new List<string> { "Left", "Middle", "Right" };
            _console.ListItems(options, true);
            var sourceRodChoice = _console.GetIntInput(0, options.Count);
            _console.WriteLine("Which rod would you like to move a disc to?");
            var destinationRodChoice = _console.GetIntInput(0, options.Count);
            //make the move
            inputHandler.SetCommand(new MoveDiscCommand(gameEditor, (RodPosition)sourceRodChoice.Input, (RodPosition)destinationRodChoice.Input));
            inputHandler.HandleInput();
            DisplayGameState(gameEditor.GameState);
        }
    }

    private void DisplayGameState(GameState gameState)
    {
        var totalDiscs = gameState.TotalDiscs;
        var leftDiscs = gameState.LeftRod.Discs.ToArray().Reverse().ToArray();
        var middleDiscs = gameState.MiddleRod.Discs.ToArray().Reverse().ToArray();
        var rightDiscs = gameState.RightRod.Discs.ToArray().Reverse().ToArray();

        _console.WriteLine("Current Game State\n");
        for (int x = totalDiscs + 1; x > 0; x--)
        {
            var lineBuilder = new StringBuilder();
            DisplayDisc(lineBuilder, leftDiscs, x, totalDiscs);
            DisplayDisc(lineBuilder, middleDiscs, x, totalDiscs);
            DisplayDisc(lineBuilder, rightDiscs, x, totalDiscs);
            _console.WriteLine(lineBuilder.ToString());
        }
        _console.WriteLine(new StringBuilder().Append('=', totalDiscs * 3).ToString());
    }

    private void DisplayDisc(StringBuilder builder, Disc[] discs, int index, int totalDiscs)
    {
        if (discs.Length >= index)
        {
            var disc = discs[index - 1];
            var leftSpacing = GetLeftSpacing((int)(totalDiscs - disc.Size));
            var rightSpacing = GetRightSpacing((int)(totalDiscs - disc.Size));
            builder.Append(' ', leftSpacing);
            builder.Append('*', (int)disc.Size);
            builder.Append(' ', rightSpacing);
        }
        else
        {
            var leftSpacing = GetLeftSpacing(totalDiscs - 1);
            var rightSpacing = GetRightSpacing(totalDiscs - 1);
            builder.Append(' ', leftSpacing);
            builder.Append('|');
            builder.Append(' ', rightSpacing);
        }
    }

    private static int GetLeftSpacing(int rodWidth)
    {
        if (rodWidth == 0)
        {
            return 0;
        }
        return rodWidth % 2 == 0 ? rodWidth / 2 : rodWidth / 2 + 1;
    }

    private static int GetRightSpacing(int rodWidth)
    {
        return rodWidth / 2;
    }
}
