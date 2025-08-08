namespace Adapter.Blueprint;

public class Response
{
    public Response(int property)
    {
        Property = property;
    }

    /// <summary>
    /// Readonly property with proper naming conventions
    /// </summary>
    public int Property { get; }
}
