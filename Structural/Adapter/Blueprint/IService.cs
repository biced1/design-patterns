namespace Adapter.Blueprint;

/// <summary>
/// Generally, you can just create a service interface to wrap the adapter.
/// The client doesn't need to know that you're adapting, just what the service is for.
/// </summary>
public interface IService
{
    /// <summary>
    /// Performs some business logic using best practice model and response
    /// </summary>
    /// <param name="data">Best practice data model</param>
    /// <returns>Best practice response model</returns>`
    Response Method(Data data);
}
