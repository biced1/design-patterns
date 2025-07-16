namespace AbstractFactory.Blueprint;

public interface IAbstractFactory
{
    IProductA CreateProductA();
    
    IProductB CreateProductB();
}