namespace AbstractFactory.CarExample.CarPart;

public class VwGtiCupHolder : ICupHolder
{
    public int Capacity => 2;

    public string Make => "Volkswagen";

    public string Model => "GTI";
}
