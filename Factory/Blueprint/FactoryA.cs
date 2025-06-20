namespace DesignPatterns.Factory.Blueprint;

public class FactoryA : IFactory
{
    public IProduct CreateProduct()
    {
        return new ProductA();
    }
}