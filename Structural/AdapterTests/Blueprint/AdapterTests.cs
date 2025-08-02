using Adapter.Blueprint;

namespace AdapterTests;

public class AdapterTests
{
    private readonly IService _adapter;
    private readonly LegacyService _legacyService;

    public AdapterTests() {
        _legacyService = new LegacyService();
        _adapter = new AdapterService(_legacyService);
    }

    [Fact]
    public void Method_ReturnsResponse()
    {
        var dataText = "Data that's easy to use.";
        var data = new Data(dataText);

        var response = _adapter.Method(data);

        Assert.Equal(dataText.Length, response.Property);
    }
}
