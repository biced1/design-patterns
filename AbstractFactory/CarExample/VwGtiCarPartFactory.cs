using AbstractFactory.CarExample.CarPart;

namespace AbstractFactory.CarExample;

public class VwGtiCarPartFactory : ICarPartFactory
{
    public ICupHolder CreateCupHolder()
    {
        return new VwGtiCupHolder();
    }

    public IEngine CreateEngine()
    {
        return new VwGtiEngine();
    }

    public ITransmission CreateTransmission()
    {
        return new VwGtiTransmission();
    }
}
