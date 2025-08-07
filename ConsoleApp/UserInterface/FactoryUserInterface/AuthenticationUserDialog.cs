using ConsoleApp.Extensions;
using ConsoleApp.Wrapper;
using Factory.AuthenticationExample;
using Factory.AuthenticationExample.Login;

namespace ConsoleApp.UserInterface.FactoryUserInterface;

public class AuthenticationUserDialog(IConsole console, UserDialogBase previousDialog) : UserDialogBase(console, previousDialog)
{
    public override string DisplayName => "Authentication";

    /// <inheritdoc />
    public override void Run()
    {
        var loginServices = new List<LoginService> {
            new BiomentricLoginService(),
            new OtpLoginService(),
            new SecurityQuestionLoginService()
        };

        var userInput = new UserInput<int?>();
        while (!userInput.ShouldGoBack)
        {
            _console.WriteLine("Which login service would you like to use?");
            _console.ListItems([.. loginServices.Select(x => x.GetType().Name)]);
            userInput = _console.GetIntInput(1, loginServices.Count);
            if (userInput.ShouldGoBack)
            {
                GoBack();
            }
            else
            {
                var user = new User();
                loginServices[userInput.Input - 1 ?? 0].Login(user);
                _console.WriteLine("User was logged in with Authentication Method " + user.AuthenticationType);
            }
        }
    }
}
