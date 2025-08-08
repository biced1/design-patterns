namespace AbstractFactory.CarExample.CarPart;

public class SubaruBrzCupHolder : ICupHolder
{
    public int Capacity => 2;

    public string Make => "Subaru";

    public string Model => "BRZ";
}
