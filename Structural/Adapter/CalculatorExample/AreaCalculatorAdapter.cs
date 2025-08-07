using Adapter.CalculatorExample.Calculator;

namespace Adapter.CalculatorExample;

public class AreaCalculatorAdapter : IAreaCalculator
{
    private readonly CalculatorService _calculator;

    public AreaCalculatorAdapter(CalculatorService calculator)
    {
        _calculator = calculator;
    }

    public double CalculateCircle(double radius)
    {
        _calculator.fa = radius;

        _calculator.cir_calc();

        return _calculator.r;
    }

    /// <summary>
    /// Calculates the area of a circle
    /// Shows ability to add overloads for functions in adapter
    /// </summary>
    /// <param name="radius"></param>
    /// <returns></returns>
    public double CalculateCircle(int radius)
    {
        return CalculateCircle(Convert.ToDouble(radius));
    }

    public double CalculateSphere(double radius)
    {
        _calculator.fa = radius;

        _calculator.sph_calc();

        return _calculator.r;
    }

    public double CalculateSphere(int radius)
    {
        return CalculateSphere(Convert.ToDouble(radius));
    }

    public double CalculateTriangle(double baseLength, double height)
    {
        _calculator.fa = baseLength;
        _calculator.sa = height;

        _calculator.tri_calc();

        return _calculator.r;
    }

    public double CalculateTriangle(int width, int height)
    {
        return CalculateTriangle(Convert.ToDouble(width), Convert.ToDouble(height));
    }

    public double CalculatePyramid(double length, double width, double height)
    {
        _calculator.fa = length;
        _calculator.sa = width;
        _calculator.aa = [height];

        _calculator.pyr_calc();

        return _calculator.r;
    }

    public double CalculatePyramid(int length, int width, int height)
    {
        return CalculatePyramid(Convert.ToDouble(length), Convert.ToDouble(width), Convert.ToDouble(height));
    }
}
