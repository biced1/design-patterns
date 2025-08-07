using Adapter.Blueprint;
using Adapter.Blueprint.Legacy;
using ConsoleApp.Extensions;
using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface.AdapterUserInterface;

public class BlueprintUserDialog(IConsole console, UserDialogBase previousDialog) : UserDialogBase(console, previousDialog)
{
    public override string DisplayName => "Blueprint";

    public override void Run()
    {
        var userInput = new IntUserInput();
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
                if (userInput.UserInput == 1)
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
