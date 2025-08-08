namespace Factory.Blueprint;

/// <summary>
/// Factory that creates a specific instance of <see cref="ProductA"/>
/// </summary>
public class FactoryA : IFactory
{
    /// <summary>
    /// Creates a specific instance of <see cref="ProductA"/>
    /// </summary>
    /// <returns>A specific instance of <see cref="ProductA"/></returns>
    public IProduct CreateProduct()
    {
        return new ProductA();
    }
}