namespace AbstractFactory.CarExample.CarPart;

public class SubaruBrzEngine : IEngine
{
    public int Cylinders => 4;

    public string Make => "Subaru";

    public string Model => "BRZ";
}
