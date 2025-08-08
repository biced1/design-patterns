namespace Factory.Blueprint;

/// <summary>
/// Factory that creates a specific instance of <see cref="ProductB"/>
/// </summary>
public class FactoryB : IFactory
{
    public IProduct CreateProduct()
    {
        /// <summary>
        /// Creates a specific instance of <see cref="ProductB"/>
        /// </summary>
        /// <returns>A specific instance of <see cref="ProductB"/></returns>
        return new ProductB();
    }
}