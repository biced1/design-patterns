using Command.Blueprint;
using ConsoleApp.Extensions;
using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface.CommandUserInterface;

public class BlueprintUserDialog(IConsole console, UserDialogBase? previousDialog) : UserDialogBase(console, previousDialog)
{
    public override string DisplayName => "Blueprint";

    public override void Run()
    {
        var receiver = new Receiver();
        var client = new Client(receiver, new Invoker());

        var userInput = new IntUserInput();
        while (!userInput.ShouldGoBack)
        {
            var options = new List<string> { "Run Command1 to add a character", "Run Command2 to delete a character", "Undo the last command" };
            _console.ListItems(options);
            userInput = _console.GetIntInput(1, options.Count);
            if (userInput.ShouldGoBack)
            {
                GoBack();
            }

            switch (userInput.UserInput)
            {
                case 1:
                    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    var randomChar = chars[new Random().Next(chars.Length)];
                    client.ExecuteCommand1(randomChar);
                    _console.WriteLine($"You added random character {randomChar}");
                    break;
                case 2:
                    client.ExecuteCommand2();
                    _console.WriteLine($"You removed the last character on the state.");
                    break;
                case 3:
                default:
                    client.Undo();
                    _console.WriteLine($"You undid the last command.");
                    break;
            }
            _console.WriteLine($"The current state of the Receiver is {receiver.State}");
        }
    }
}
