namespace AbstractFactory.Blueprint;

/// <inheritdoc />
public class ConcreteFactory1 : IAbstractFactory
{
    /// <inheritdoc />
    public IProductA CreateProductA()
    {
        return new ProductA1();
    }

    /// <inheritdoc />
    public IProductB CreateProductB()
    {
        return new ProductB1();
    }
}
