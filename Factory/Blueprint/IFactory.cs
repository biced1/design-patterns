namespace DesignPatterns.Factory.Blueprint;

/// <summary>
/// Factory interface. 
/// Allows for the creation of various base classes that create concrete implementations of a product
/// </summary>
public interface IFactory
{
    /// <summary>
    /// Creates a generic product, depending on which sub class is used.
    /// </summary>
    /// <returns>A concrete product implementation, wrapped in a product interface.</returns>
    IProduct CreateProduct();
}