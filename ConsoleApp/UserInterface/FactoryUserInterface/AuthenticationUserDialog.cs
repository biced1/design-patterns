using ConsoleApp.Extensions;
using ConsoleApp.Wrapper;
using Factory.AuthenticationExample;
using Factory.AuthenticationExample.Login;

namespace ConsoleApp.UserInterface.FactoryUserInterface;

/// <summary>
/// Dialog that lets the user try the authentication Factory pattern.
/// </summary>
/// <param name="console"><see cref="IConsole"/> used to interact with the console.</param>
/// <param name="previousDialog">The most recent <see cref="UserDialogBase"/> that was ran, to allow the user to navigate back in dialog options.</param>
public class AuthenticationUserDialog(IConsole console, UserDialogBase previousDialog) : UserDialogBase(console, previousDialog)
{
    /// <inheritdoc />
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
