namespace ConsoleApp.UserInterface;

public class UserInput<T>
{
    public T? Input { get; set; }
    public bool ShouldGoBack { get; set; } = false;
}
