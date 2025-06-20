namespace DesignPatterns.ConsoleHelper;

public static class InputHelper
{

    /// <summary>
    /// Retrieves user input as an integer betweeen a range of numbers (inclusive).
    /// </summary>
    /// <param name="message">The message to be displayed for every attempt to retrieve input.</param>
    /// <param name="minimum">The lowest number that will be accepted.</param>
    /// <param name="maximum">The highest number that will be accepted.</param>
    /// <returns>The captured input, or null if cancelled.</returns>
    public static int? GetIntInput(IConsole console, string message, int minimum = int.MinValue, int maximum = int.MaxValue)
    {
        if (minimum > maximum)
        {
            throw new ArgumentException("Minimum must be less than or equal to maximum");
        }

        var wasSuccessful = false;
        int? capturedInput = null;
        while (!wasSuccessful)
        {
            console.Write(message);
            var input = console.ReadLine();
            if (input == "q")
            {
                return null;
            }

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
        return capturedInput;

    }
}