using AbstractFactory.CarExample.CarPart;

namespace AbstractFactory.CarExample;

/// <summary>
/// A factory that creates cars.
/// In this case, named it a factory. In practice it may be called a builder or service.
/// </summary>
public interface ICarPartFactory
{
    IEngine CreateEngine();

    ITransmission CreateTransmission();

    ICupHolder CreateCupHolder();
}
