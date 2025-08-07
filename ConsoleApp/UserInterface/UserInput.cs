namespace ConsoleApp.UserInterface;

/// <summary>
/// Represents a user input.
/// They may either enter an input with the correct type, 
/// or indicate that they would like go back to the previous dialog
/// </summary>
/// <typeparam name="T">Type of input expected from the user.</typeparam>
public class UserInput<T>
{
    public T? Input { get; set; }
    public bool ShouldGoBack { get; set; } = false;
}
