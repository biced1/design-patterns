namespace Adapter.Blueprint;

public class LegacyService
{
    /// <summary>
    /// Perform some complex business logic and return special model
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public SpecialResponse ServiceMethod(SpecialData data)
    {
        var response = new SpecialResponse();
        response.i_property = data.name.Length;
        return response;
    }
}
