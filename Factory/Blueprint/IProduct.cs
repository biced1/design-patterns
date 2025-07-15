namespace DesignPatterns.Factory.Blueprint;

/// <summary>
/// Product Interface.
/// Represents a generic product that can do stuff.
/// </summary>
public interface IProduct
{
    /// <summary>
    /// Does some stuff.
    /// </summary>
    void DoStuff();

    /// <summary>
    /// Represents the nickname of the product to easily understand what kind of product it is.
    /// </summary>
    /// <returns>The nickname of the product.</returns>
    string Nickname {
        get;
    }
}