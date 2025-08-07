using AbstractFactory.CarExample;

namespace AbstractFactoryTests.CarExample;

public class CarPartFactoryTests
{
    private ICarPartFactory? carPartFactory;

    [Fact]
    public void CreateEngine_CreatesVwGtiParts()
    {
        carPartFactory = new VwGtiCarPartFactory();

        var expectedMake = "Volkswagen";
        var expectedModel = "GTI";

        var engine = carPartFactory.CreateEngine();
        var transmission = carPartFactory.CreateTransmission();
        var cupHolder = carPartFactory.CreateCupHolder();

        Assert.Equal(expectedMake, engine.Make);
        Assert.Equal(expectedModel, engine.Model);
        Assert.Equal(4, engine.Cylinders);

        Assert.Equal(expectedMake, transmission.Make);
        Assert.Equal(expectedModel, transmission.Model);
        Assert.Equal(5, transmission.Gears);

        Assert.Equal(expectedMake, cupHolder.Make);
        Assert.Equal(expectedModel, cupHolder.Model);
        Assert.Equal(2, cupHolder.Capacity);
    }

    [Fact]
    public void CreateEngine_CreatesSubaruBrzParts()
    {
        carPartFactory = new SubaruBrzCarPartFactory();

        var expectedMake = "Subaru";
        var expectedModel = "BRZ";

        var engine = carPartFactory.CreateEngine();
        var transmission = carPartFactory.CreateTransmission();
        var cupHolder = carPartFactory.CreateCupHolder();

        Assert.Equal(expectedMake, engine.Make);
        Assert.Equal(expectedModel, engine.Model);
        Assert.Equal(4, engine.Cylinders);

        Assert.Equal(expectedMake, transmission.Make);
        Assert.Equal(expectedModel, transmission.Model);
        Assert.Equal(6, transmission.Gears);

        Assert.Equal(expectedMake, cupHolder.Make);
        Assert.Equal(expectedModel, cupHolder.Model);
        Assert.Equal(2, cupHolder.Capacity);
    }
}
