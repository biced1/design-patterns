namespace DesignPatterns.Factory.Blueprint;

public class FactoryB : IFactory
{
    public IProduct CreateProduct()
    {
        return new ProductB();
    }
}