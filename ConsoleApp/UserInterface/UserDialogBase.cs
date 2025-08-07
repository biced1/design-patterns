using ConsoleApp.Extensions;
using ConsoleApp.Wrapper;

namespace ConsoleApp.UserInterface;

/// <summary>
/// Base class for a UserDialog.
/// Allows for lists of dialogs to be ran based on user selection.
/// </summary>
public abstract class UserDialogBase
{
    private readonly UserDialogBase _previousDialog;
    protected readonly IConsole _console;

    /// <summary>
    /// Creates a concrete implementation of <see cref="UserDialogBase"/>
    /// </summary>
    /// <param name="console"><see cref="IConsole"/> used to interact with the console.</param>
    /// <param name="previousDialog">The most recent <see cref="UserDialogBase"/> that was ran, to allow the user to navigate back in dialog options.</param>
    public UserDialogBase(IConsole console, UserDialogBase? previousDialog)
    {
        _console = console;
        _previousDialog = previousDialog ?? this;
    }

    /// <summary>
    /// Allows the user to go back to the most recent dialog options.
    /// </summary>
    public void GoBack()
    {
        _previousDialog.Run();
    }

    /// <summary>
    /// Runs the dialog options to allow a user to make selections.
    /// </summary>
    public abstract void Run();

    /// <summary>
    /// Friendly name to display to the user so they can more easily choose between dialog options.
    /// </summary>
    public abstract string DisplayName { get; }

    /// <summary>
    /// Displays a list of dialog options to present to the user.
    /// Allows them to select which dialog to navigate next.
    /// </summary>
    /// <param name="options">A list of <see cref="UserDialogBase"/> to allow the user to select from.</param>
    /// <param name="welcomeMessage">Message to be displayed to the user before the list is presented.</param>
    public void RunSelectedPattern(List<UserDialogBase> options, string welcomeMessage)
    {
        _console.WriteLine(welcomeMessage);
        _console.ListItems([.. options.Select(x => x.DisplayName)]);
        var option = _console.GetIntInput(1, options.Count);
        if (option.ShouldGoBack)
        {
            GoBack();
        }

        options[option.Input - 1 ?? 0].Run();
    }
}