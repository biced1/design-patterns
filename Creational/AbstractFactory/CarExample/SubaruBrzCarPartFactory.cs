using AbstractFactory.CarExample.CarPart;

namespace AbstractFactory.CarExample;

/// <inheritdoc />
public class SubaruBrzCarPartFactory : ICarPartFactory
{
    /// <inheritdoc />
    public ICupHolder CreateCupHolder()
    {
        return new SubaruBrzCupHolder();
    }

    /// <inheritdoc />
    public IEngine CreateEngine()
    {
        return new SubaruBrzEngine();
    }

    /// <inheritdoc />
    public ITransmission CreateTransmission()
    {
        return new SubaruBrzTransmission();
    }
}
