namespace AbstractFactory.CarExample.CarPart;

public class SubaruBrzTransmission : ITransmission
{
    public int Gears => 6;

    public string Make => "Subaru";

    public string Model => "BRZ";
}
