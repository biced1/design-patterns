using DesignPatterns.Factory.Blueprint;

namespace FactoryTests.Blueprint;

public class FactoryTests
{
    private IFactory? factory;

    [Fact]
    public void CreateProduct_CreatesProductA()
    {
        factory = new FactoryA();

        var product = factory.CreateProduct();

        Assert.IsType<ProductA>(product);
    }

    [Fact]
    public void CreateProduct_CreatesProductB()
    {
        factory = new FactoryB();

        var product = factory.CreateProduct();

        Assert.IsType<ProductB>(product);
    }
}
