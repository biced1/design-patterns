namespace AbstractFactory.CarExample.CarPart;

public interface ITransmission : IMetadata
{
    int Gears { get; }
}
