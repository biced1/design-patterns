namespace Adapter.Blueprint;

public class Adapter : IAdapter
{
    private readonly LegacyService _legacyService;

    public Adapter(LegacyService legacyService)
    {
        _legacyService = legacyService;
    }

    public Response Method(Data data)
    {
        var specialData = new SpecialData
        {
            name = data.Name.ToCharArray()
        };

        var specialResponse = _legacyService.ServiceMethod(specialData);

        return new Response(specialResponse.i_property);
    }
}
