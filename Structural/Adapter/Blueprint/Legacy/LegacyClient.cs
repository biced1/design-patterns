namespace Adapter.Blueprint.Legacy;

public class LegacyClient
{
    private readonly LegacyService _legacyService;

    public LegacyClient(LegacyService service)
    {
        _legacyService = service;
    }

    public void FooBar()
    {
        var data = new SpecialData
        {
            name = ['S', 'p', 'e', 'c', 'i', 'a', 'l']
        };
        var response = _legacyService.ServiceMethod(data);
        Console.WriteLine($"My special name has a length of {response.i_property}");
    }
}
