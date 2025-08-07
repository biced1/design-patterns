using Adapter.Blueprint;
using Adapter.Blueprint.Legacy;

namespace AdapterTests.Blueprint;

public class AdapterTests
{
    private readonly IService _adapter;
    private readonly LegacyService _legacyService;

    public AdapterTests()
    {
        _legacyService = new LegacyService();
        _adapter = new AdapterService(_legacyService);
    }

    [Fact]
    public void ServiceMethod_ReturnsSpecialResponse()
    {
        var data = new SpecialData
        {
            name = ['S', 'p', 'e', 'c', 'i', 'a', 'l']
        };
        var specialResponse = _legacyService.ServiceMethod(data);

        Assert.Equal(data.name.Length, specialResponse.i_property);
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
