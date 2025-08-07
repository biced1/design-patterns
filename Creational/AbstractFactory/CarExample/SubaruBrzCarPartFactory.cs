using AbstractFactory.CarExample.CarPart;

namespace AbstractFactory.CarExample;

public class SubaruBrzCarPartFactory : ICarPartFactory
{
    public ICupHolder CreateCupHolder()
    {
        return new SubaruBrzCupHolder();
    }

    public IEngine CreateEngine()
    {
        return new SubaruBrzEngine();
    }

    public ITransmission CreateTransmission()
    {
        return new SubaruBrzTransmission();
    }
}
