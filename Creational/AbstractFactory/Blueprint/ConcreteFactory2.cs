namespace AbstractFactory.Blueprint;

/// <inheritdoc />
public class ConcreteFactory2 : IAbstractFactory
{
    /// <inheritdoc />
    public IProductA CreateProductA()
    {
        return new ProductA2();
    }

    /// <inheritdoc />
    public IProductB CreateProductB()
    {
        return new ProductB2();
    }
}