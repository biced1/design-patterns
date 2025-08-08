namespace AbstractFactory.CarExample.CarPart;

public interface IEngine : IMetadata
{
    int Cylinders { get; }
}
