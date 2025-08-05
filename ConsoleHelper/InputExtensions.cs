namespace ConsoleHelper;

public static class InputExtensions
{

    /// <summary>
    /// Retrieves user input as an integer betweeen a range of numbers (inclusive).
    /// </summary>
    /// <param name="message">The message to be displayed for every attempt to retrieve input.</param>
    /// <param name="minimum">The lowest number that will be accepted, inclusive.</param>
    /// <param name="maximum">The highest number that will be accepted, inclusive.</param>
    /// <returns>The captured input, or null if cancelled.</returns>
    public static IntUserInput GetIntInput(this IConsole console, int minimum = int.MinValue, int maximum = int.MaxValue)
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
            if (input == "q")
            {
                Environment.Exit(0);
            }
            if (input == "b")
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
        return new IntUserInput { UserInput = capturedInput, ShouldGoBack = shouldGoBack };

    }
}