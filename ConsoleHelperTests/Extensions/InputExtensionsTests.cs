using ConsoleApp.Wrapper;
using ConsoleApp.Extensions;
using Moq;
using ConsoleApp.UserInterface;

namespace ConsoleAppTests.Extensions;

public class InputExtensionsTests
{
    private readonly Mock<IConsole> consoleMock;

    public InputExtensionsTests()
    {
        consoleMock = new Mock<IConsole>();
    }

    [Fact]
    public void GetIntInput_ReturnsValidInput()
    {
        consoleMock.Setup(x => x.ReadLine()).Returns("2");

        var result = consoleMock.Object.GetIntInput(0, 3);

        Assert.Equal(2, result.Input);
    }

    [Theory]
    [InlineData(0, 5, "200")]
    [InlineData(0, 5, "-200")]
    [InlineData(-1000, 1000, "clearly not a number")]
    public void GetIntInput_IgnoresInvalidInput(int minimum, int maximum, string invalidInput)
    {

        consoleMock.Setup(x => x.ReadLine()).Returns(invalidInput);
        consoleMock.Setup(x => x.ReadLine()).Returns(SelectionConstants.BACK);

        var result = consoleMock.Object.GetIntInput(minimum, maximum);

        Assert.Null(result.Input);
    }

    [Fact]
    public void GetDoubleInput_ReturnsValidInput()
    {
        consoleMock.Setup(x => x.ReadLine()).Returns("2.243");

        var result = consoleMock.Object.GetDoubleInput();

        Assert.Equal(2.243, result);
    }

    [Fact]
    public void GetDoubleInput_IgnoresInvalidInput()
    {
        consoleMock.Setup(x => x.ReadLine()).Returns("clearly not a number");
        consoleMock.Setup(x => x.ReadLine()).Returns("0");

        var result = consoleMock.Object.GetDoubleInput();

        Assert.Equal(0, result);
    }
}