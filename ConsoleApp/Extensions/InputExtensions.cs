using ConsoleApp.UserInterface;
using ConsoleApp.Wrapper;

namespace ConsoleApp.Extensions;

public static class InputExtensions
{

    /// <summary>
    /// Retrieves user input as an integer betweeen a range of numbers (inclusive).
    /// </summary>
    /// <param name="message">The message to be displayed for every attempt to retrieve input.</param>
    /// <param name="minimum">The lowest number that will be accepted, inclusive.</param>
    /// <param name="maximum">The highest number that will be accepted, inclusive.</param>
    /// <param name="listOnly">Determines if system constants should be accepted as values.</param>
    /// <returns>The captured input, or null if cancelled.</returns>
    public static UserInput<int?> GetIntInput(this IConsole console, int minimum = int.MinValue, int maximum = int.MaxValue, bool listOnly = false)
    {
        if (minimum > maximum)
        {
            throw new ArgumentException("Minimum must be less than or equal to maximum");
        }

        var wasSuccessful = false;
        int? capturedInput = null;
        var shouldGoBack = false;
        while (!wasSuccessful)
        {
            var input = console.ReadLine()?.ToLower();
            if (input == SelectionConstants.QUIT && !listOnly)
            {
                Environment.Exit(0);
            }
            if (input == SelectionConstants.BACK && !listOnly)
            {
                shouldGoBack = true;
                wasSuccessful = true;
            }
            else
            {
                wasSuccessful = int.TryParse(input, out var parsedInput);

                wasSuccessful = wasSuccessful && parsedInput >= minimum && parsedInput <= maximum;

                if (wasSuccessful)
                {
                    capturedInput = parsedInput;
                }
                else
                {
                    console.WriteLine("Invalid input. Please try again, or press q to cancel.");
                }
            }
        }
        console.WriteLine("");
        return new UserInput<int?> { Input = capturedInput, ShouldGoBack = shouldGoBack };
    }

    /// <summary>
    /// Retrieves user input as a double.
    /// </summary>
    /// <returns>A double representing the user input.</returns>
    public static double GetDoubleInput(this IConsole console)
    {
        var wasSuccessful = false;
        double capturedInput = 0;
        while (!wasSuccessful)
        {
            var input = console.ReadLine()?.ToLower();
            wasSuccessful = double.TryParse(input, out var parsedInput);

            if (wasSuccessful)
            {
                capturedInput = parsedInput;
            }
            else
            {
                console.WriteLine("Invalid input. Please try again.");
            }
        }

        console.WriteLine("");
        return capturedInput;
    }
}