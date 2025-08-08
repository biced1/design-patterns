using ConsoleApp.Wrapper;
using ConsoleApp.Extensions;
using Moq;

namespace ConsoleAppTests.Extensions;

public class OutputExtensionsTests
{
    private readonly Mock<IConsole> consoleMock;

    public OutputExtensionsTests()
    {
        consoleMock = new Mock<IConsole>();
    }

    [Fact]
    public void ListItems_ListsItemsWithBackAndQuit()
    {
        var capturedMessages = new List<string>();
        consoleMock.Setup(x => x.WriteLine(It.IsAny<string>()))
            .Callback((string x) => capturedMessages.Add(x));

        var options = new List<string> { "test", "options" };

        consoleMock.Object.ListItems(options);

        var expectedValues = new List<string> { "\t1: test", "\t2: options", "\tb: back", "\tq: quit" };

        Assert.Equal(expectedValues.Count, capturedMessages.Count);

        for (int x = 0; x < capturedMessages.Count; x++)
        {
            Assert.Equal(expectedValues[x], capturedMessages[x]);
        }
    }

    [Fact]
    public void ListItems_ListsItemsWithoutBackAndQuit()
    {
        var capturedMessages = new List<string>();
        consoleMock.Setup(x => x.WriteLine(It.IsAny<string>()))
            .Callback((string x) => capturedMessages.Add(x));

        var options = new List<string> { "test", "options" };

        consoleMock.Object.ListItems(options, true);

        var expectedValues = new List<string> { "\t1: test", "\t2: options" };

        Assert.Equal(expectedValues.Count, capturedMessages.Count);

        for (int x = 0; x < capturedMessages.Count; x++)
        {
            Assert.Equal(expectedValues[x], capturedMessages[x]);
        }
    }
}
