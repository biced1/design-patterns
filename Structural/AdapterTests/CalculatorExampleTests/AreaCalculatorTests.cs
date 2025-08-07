using Adapter.CalculatorExample;
using Adapter.CalculatorExample.Calculator;

namespace AdapterTests.CalculatorExampleTests;

public class AreaCalculatorTests
{
    private readonly CalculatorService _calculatorService;
    private readonly IAreaCalculator _areaCalculator;

    public AreaCalculatorTests()
    {
        _calculatorService = new CalculatorService();
        _areaCalculator = new AreaCalculatorAdapter(_calculatorService);
    }

    [Fact]
    public void CalculateCircle_CalculatesCorrectly()
    {
        var radius = 4.23;

        var area = _areaCalculator.CalculateCircle(radius);

        Assert.Equal(56.212203191416819, area);
    }

    [Fact]
    public void CalculateCircle_CalculatesCorrectly_WithInt()
    {
        var radius = 4;
        var area = _areaCalculator.CalculateCircle(radius);

        Assert.Equal(50.26548245743669, area);
    }

    [Fact]
    public void CalculateSphere_CalculatesCorrectly()
    {
        var radius = 4.23;

        var area = _areaCalculator.CalculateSphere(radius);

        Assert.Equal(224.84881276566728, area);
    }

    [Fact]
    public void CalculateSphere_CalculatesCorrectly_WithInt()
    {
        var radius = 4;
        var area = _areaCalculator.CalculateSphere(radius);

        Assert.Equal(201.06192982974676, area);
    }

    [Fact]
    public void CalculateTriangle_CalculatesCorrectly()
    {
        var width = 4.23;
        var height = 1.33;

        var area = _areaCalculator.CalculateTriangle(width, height);

        Assert.Equal(2.8129500000000003, area);
    }

    [Fact]
    public void CalculateTriangle_CalculatesCorrectly_WithInt()
    {
        var width = 4;
        var height = 1;

        var area = _areaCalculator.CalculateTriangle(width, height);

        Assert.Equal(2, area);
    }

    [Fact]
    public void CalculatePyramid_CalculatesCorrectly()
    {
        var length = 5.11;
        var width = 4.23;
        var height = 1.33;

        var area = _areaCalculator.CalculatePyramid(length, width, height);

        Assert.Equal(46.566503368976996, area);
    }

    [Fact]
    public void CalculatePyramid_CalculatesCorrectly_WithInt()
    {
        var length = 5;
        var width = 4;
        var height = 1;

        var area = _areaCalculator.CalculatePyramid(length, width, height);

        Assert.Equal(41.950669501767955, area);
    }
}
