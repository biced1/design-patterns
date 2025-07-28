namespace AbstractFactory.Blueprint;

/// <summary>
/// An abstract factory for a family of related products.
/// </summary>
public interface IAbstractFactory
{
    IProductA CreateProductA();

    IProductB CreateProductB();
}