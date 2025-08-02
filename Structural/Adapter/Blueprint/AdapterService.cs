namespace Adapter.Blueprint;

public class AdapterService : IService
{
    private readonly LegacyService _legacyService;

    public AdapterService(LegacyService legacyService)
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
