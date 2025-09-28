using System.Text;
using Command.HanoiExample;
using Command.HanoiExample.Command;
using Command.HanoiExample.Model;
using ConsoleApp.Extensions;
using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface.CommandUserInterface;

/// <summary>
/// A user dialog that allows a user to play Towers of Hanoi using the command pattern.
/// Represents the Application or Client in the command pattern.
/// </summary>
/// <param name="console"><see cref="IConsole"/> used to interact with the console.</param>
/// <param name="previousDialog">The most recent <see cref="UserDialogBase"/> that was ran, to allow the user to navigate back in dialog options.</param>
public class HanoiExampleUserDialog(IConsole console, UserDialogBase? previousDialog) : UserDialogBase(console, previousDialog)
{
    
    /// <inheritdoc />
    public override string DisplayName => "Towers of Hanoi Game";

    /// <inheritdoc />
    public override void Run()
    {
        var gameEditor = new GameEditor();
        var inputHandler = new InputHandler();
        var commandHistory = new Stack<ICommand>();
        inputHandler.SetCommand(new NewGameCommand(gameEditor, 6));
        inputHandler.HandleInput();

        _console.WriteLine($"Welcome to Towers of Hanoi Game.\nThe objective is to move all discs from one rod to any of the other rods.\nThe catch? You cannot move a larger rod on top of a smaller rod. Enjoy!");

        DisplayGameState(gameEditor.GameState);

        var sourceRodChoice = new UserInput<int?>();
        var destinationRodChoice = new UserInput<int?>();
        var hasWon = false;
        while (!sourceRodChoice.ShouldGoBack && !destinationRodChoice.ShouldGoBack && !hasWon)
        {
            _console.WriteLine("Which rod would you like to move a disc from? (or press 4 to undo the last move)");
            var options = new List<string> { "Left", "Middle", "Right", "Undo" };
            _console.ListItems(options, true);
            sourceRodChoice = _console.GetIntInput(0, options.Count);
            if (!sourceRodChoice.ShouldGoBack && sourceRodChoice.Input == 4)
            {
                Undo(commandHistory);
            }
            else
            {
                _console.WriteLine("Which rod would you like to move a disc to?");
                destinationRodChoice = _console.GetIntInput(0, options.Count - 1);

                if (sourceRodChoice.Input != null && destinationRodChoice.Input != null)
                {
                    var moveDiscCommand = new MoveDiscCommand(gameEditor, (RodPosition)sourceRodChoice.Input, (RodPosition)destinationRodChoice.Input);
                    inputHandler.SetCommand(moveDiscCommand);
                    inputHandler.HandleInput();
                    commandHistory.Push(moveDiscCommand);
                }
                else
                {
                    _console.WriteLine("Invalid input. Please try again, or press q to cancel.");
                }
            }

            DisplayGameState(gameEditor.GameState);
            if (gameEditor.HasWon())
            {
                hasWon = true;
                _console.WriteLine("Congratulations, you're a master of the rods! Enter any key(s) to celebrate.");
                _console.ReadLine();
            }
        }
    }

    private void DisplayGameState(GameState gameState)
    {
        var totalDiscs = gameState.TotalDiscs;
        var leftDiscs = gameState.LeftRod.Discs.ToArray().Reverse().ToArray();
        var middleDiscs = gameState.MiddleRod.Discs.ToArray().Reverse().ToArray();
        var rightDiscs = gameState.RightRod.Discs.ToArray().Reverse().ToArray();

        _console.WriteLine("Current Game State\n");
        for (var x = totalDiscs + 1; x > 0; x--)
        {
            var lineBuilder = new StringBuilder();
            DisplayDisc(lineBuilder, leftDiscs, x, totalDiscs);
            DisplayDisc(lineBuilder, middleDiscs, x, totalDiscs);
            DisplayDisc(lineBuilder, rightDiscs, x, totalDiscs);
            _console.WriteLine(lineBuilder.ToString());
        }
        _console.WriteLine(new StringBuilder().Append('=', totalDiscs * 3).ToString());
    }

    private static void DisplayDisc(StringBuilder builder, Disc[] discs, int index, int totalDiscs)
    {
        if (discs.Length < index)
        {
            DisplayRod(builder, totalDiscs);
        }
        else
        {
            var disc = discs[index - 1];
            var leftSpacing = GetLeftSpacing((int)(totalDiscs - disc.Size));
            var rightSpacing = GetRightSpacing((int)(totalDiscs - disc.Size));
            builder.Append(' ', leftSpacing);
            builder.Append('*', (int)disc.Size);
            builder.Append(' ', rightSpacing);
        }
    }

    private static void DisplayRod(StringBuilder builder, int totalDiscs)
    {
        var leftSpacing = GetLeftSpacing(totalDiscs - 1);
        var rightSpacing = GetRightSpacing(totalDiscs - 1);
        builder.Append(' ', leftSpacing);
        builder.Append('|');
        builder.Append(' ', rightSpacing);
    }

    private static int GetLeftSpacing(int rodWidth)
    {
        if (rodWidth == 0)
        {
            return 0;
        }
        return rodWidth % 2 == 0 ? rodWidth / 2 : rodWidth / 2 + 1;
    }

    private static int GetRightSpacing(int rodWidth) => rodWidth / 2;

    private static void Undo(Stack<ICommand> commandHistory)
    {
        if (commandHistory.Count != 0)
        {
            var command = commandHistory.Pop();
            command.Undo();
        }
    }
}
