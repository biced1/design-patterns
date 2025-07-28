using System;

namespace AbstractFactory.Blueprint;

public class ConcreteFactory2 : IAbstractFactory
{
    public IProductA CreateProductA()
    {
        return new ProductA2();
    }

    public IProductB CreateProductB()
    {
        return new ProductB2();
    }
}