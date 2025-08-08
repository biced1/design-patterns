namespace AbstractFactory.Blueprint;

/// <summary>
/// An abstract factory for a family of related products.
/// It is very similar to the Factory pattern, except that it creates multiple, related products.
/// </summary>
public interface IAbstractFactory
{
    /// <summary>
    /// Creates an instance of <see cref="IProductA"/> specific to each factory implementation.
    /// </summary>
    /// <returns>An instance of <see cref="IProductA"/>.</returns>
    IProductA CreateProductA();

    /// <summary>
    /// Creates an instance of <see cref="IProductB"/> specific to each factory implementation.
    /// </summary>
    /// <returns>An instance of <see cref="IProductB"/>.</returns>
    IProductB CreateProductB();
}