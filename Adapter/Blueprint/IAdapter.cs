namespace Adapter.Blueprint;

public interface IAdapter
{
    /// <summary>
    /// Performs some business logic using best practice model and response
    /// </summary>
    /// <param name="data">Best practice data model</param>
    /// <returns>Best practice response model</returns>
    Response Method(Data data);
}
