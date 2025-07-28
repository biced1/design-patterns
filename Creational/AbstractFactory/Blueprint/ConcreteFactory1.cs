using System;

namespace AbstractFactory.Blueprint;

public class ConcreteFactory1 : IAbstractFactory
{
    public IProductA CreateProductA()
    {
        return new ProductA1();
    }

    public IProductB CreateProductB()
    {
        return new ProductB1();
    }
}
