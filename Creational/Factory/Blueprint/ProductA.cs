namespace Factory.Blueprint;

/// <summary>
/// ProductA is a thingy that does stuff specific to product A.
/// </summary>
public class ProductA : IProduct
{
    /// <inheritdoc />
    public void DoStuff()
    {
        Console.WriteLine("Doing some stuff in product A");
    }

    /// <inheritdoc />
    public string Nickname
    {
        get => "Thingy";
    }
}