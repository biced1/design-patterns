using AbstractFactory.Blueprint;

namespace AbstractFactoryTests.Blueprint;

public class AbstractFactoryTests
{
    private IAbstractFactory? abstractFactory;

    [Fact]
    public void CreateProductA_CreatesFactory1Items()
    {
        abstractFactory = new ConcreteFactory1();

        var product = abstractFactory.CreateProductA();

        Assert.IsType<ProductA1>(product);
    }

    [Fact]
    public void CreateProductB_CreatesFactory1Items()
    {
        abstractFactory = new ConcreteFactory1();

        var product = abstractFactory.CreateProductB();

        Assert.IsType<ProductB1>(product);
    }
    
    [Fact]
    public void CreateProductA_CreatesFactory2Items()
    {
        abstractFactory = new ConcreteFactory2();

        var product = abstractFactory.CreateProductA();

        Assert.IsType<ProductA2>(product);
    }
    
    [Fact]
    public void CreateProductB_CreatesFactory2Items()
    {
        abstractFactory = new ConcreteFactory2();

        var product = abstractFactory.CreateProductB();

        Assert.IsType<ProductB2>(product);
    }
}
