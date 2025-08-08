using Adapter.Blueprint;
using Adapter.Blueprint.Legacy;
using ConsoleApp.Extensions;
using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface.AdapterUserInterface;

/// <summary>
/// Dialog that lets the user try the blueprint Adapter pattern.
/// </summary>
/// <param name="console"><see cref="IConsole"/> used to interact with the console.</param>
/// <param name="previousDialog">The most recent <see cref="UserDialogBase"/> that was ran, to allow the user to navigate back in dialog options.</param>
public class BlueprintUserDialog(IConsole console, UserDialogBase previousDialog) : UserDialogBase(console, previousDialog)
{
    /// <inheritdoc />
    public override string DisplayName => "Blueprint";

    /// <inheritdoc />
    public override void Run()
    {
        var userInput = new UserInput<int?>();
        while (!userInput.ShouldGoBack)
        {
            var options = new List<string>
            {
                "Legacy Service",
                "Adapter Service"
            };
            _console.WriteLine("Please select a service to use");
            _console.ListItems(options);
            userInput = _console.GetIntInput(1, options.Count);
            if (userInput.ShouldGoBack)
            {
                GoBack();
            }
            else
            {
                var legacyService = new LegacyService();
                if (userInput.Input == 1)
                {
                    var data = new SpecialData
                    {
                        name = ['S', 'p', 'e', 'c', 'i', 'a', 'l']
                    };

                    var specialResponse = legacyService.ServiceMethod(data);
                    _console.WriteLine($"The legacy service let me know that the word \"Special\" has a length of {specialResponse.i_property}");
                    _console.WriteLine("But it was way harder to use!");
                }
                else
                {
                    var adapterService = new AdapterService(legacyService);

                    var data = new Data("Adapter");

                    var response = adapterService.Method(data);
                    _console.WriteLine($"The adapter service let me know that the word \"Adapter\" has a length of {response.Property}");
                    _console.WriteLine("It was so easy to use!");
                }
            }
        }
    }
}
