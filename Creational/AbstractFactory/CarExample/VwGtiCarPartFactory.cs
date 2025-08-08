using AbstractFactory.CarExample.CarPart;

namespace AbstractFactory.CarExample;

/// <inheritdoc />
public class VwGtiCarPartFactory : ICarPartFactory
{
    /// <inheritdoc />
    public ICupHolder CreateCupHolder()
    {
        return new VwGtiCupHolder();
    }

    /// <inheritdoc />
    public IEngine CreateEngine()
    {
        return new VwGtiEngine();
    }

    /// <inheritdoc />
    public ITransmission CreateTransmission()
    {
        return new VwGtiTransmission();
    }
}
