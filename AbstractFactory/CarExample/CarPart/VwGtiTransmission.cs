namespace AbstractFactory.CarExample.CarPart;

public class VwGtiTransmission : ITransmission
{
    public int Gears => 5;

    public string Make => "Volkswagen";

    public string Model => "GTI";
}
