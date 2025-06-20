using DesignPatterns.ConsoleHelper;
using Moq;

namespace ConsoleHelperTests;

public class InputHelperTests
{
    private readonly Mock<IConsole> consoleMock;

    public InputHelperTests()
    {
        consoleMock = new Mock<IConsole>();
    }

    [Fact]
    public void GetIntInput_ReturnsValidInput()
    {
        consoleMock.Setup(x => x.ReadLine()).Returns("2");

        var result = InputHelper.GetIntInput(consoleMock.Object, "Test input", 0, 3);

        Assert.Equal(2, result);
    }

    [Theory]
    [InlineData(0, 5, "200")]
    [InlineData(0, 5, "-200")]
    [InlineData(-1000, 1000, "clearly not a number")]
    public void GetIntInput_IgnoresInvalidInput(int minimum, int maximum, string invalidInput)
    {

        consoleMock.Setup(x => x.ReadLine()).Returns(invalidInput);
        consoleMock.Setup(x => x.ReadLine()).Returns("q");

        var result = InputHelper.GetIntInput(consoleMock.Object, "Test input", minimum, maximum);

        Assert.Null(result);
    }
}