namespace DesignPatterns.Factory.Blueprint;

/// <summary>
/// ProductA is a device that does stuff specific to product B.
/// </summary>
public class ProductB : IProduct
{
    /// <inheritdoc />
    public void DoStuff()
    {
        Console.WriteLine("Doing some different stuff in product B");
    }

    /// <inheritdoc />
    public string Nickname
    {
        get => "Device";
    }
}