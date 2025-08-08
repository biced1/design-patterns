namespace AbstractFactory.CarExample.CarPart;

public class VwGtiEngine : IEngine
{
    public int Cylinders => 4;

    public string Make => "Volkswagen";

    public string Model => "GTI";
}
