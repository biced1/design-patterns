namespace ConsoleHelper;

public abstract class UserDialogBase
{
    private readonly UserDialogBase _previousDialog;
    protected readonly IConsole _console;

    public UserDialogBase(IConsole console, UserDialogBase? previousDialog)
    {
        _console = console;
        _previousDialog = previousDialog ?? this;
    }

    public void GoBack()
    {
        _previousDialog.Run();
    }

    public abstract void Run();

    public abstract string DisplayName { get; }

    public void RunSelectedPattern(List<UserDialogBase> options, string welcomeMessage)
    {
        _console.WriteLine(welcomeMessage);
        _console.ListItems([.. options.Select(x => x.DisplayName)]);
        var option = _console.GetIntInput(1, options.Count);
        if (option.ShouldGoBack)
        {
            GoBack();
        }

        options[option.UserInput - 1 ?? 0].Run();
    }
}