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
}