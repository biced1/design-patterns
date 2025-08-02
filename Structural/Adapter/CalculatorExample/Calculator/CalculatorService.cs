namespace Adapter.CalculatorExample.Calculator;

/// <summary>
/// Legacy service that performs various calculations.
/// This is an example of a service that is not very friendly to work with, but has tested and proven business logic.
/// Imagine that there are hundreds of references to this class already, and making any small changes is high risk.
/// </summary>
public class CalculatorService
{
    public double r;
    public double fa;
    public double sa;
    public double[] aa = new double[10];

    public void cir_calc()
    {
        r = Math.PI * fa * fa;
    }

    public void sph_calc()
    {
        r = 4 * Math.PI * fa * fa;
    }

    public void tri_calc()
    {
        r = .5 * fa * sa;
    }

    public void pyr_calc()
    {
        r = (fa * sa) + (fa * Math.Sqrt(Math.Pow(sa / 2, 2) + Math.Pow(aa[0], 2))) + (sa * Math.Sqrt(Math.Pow(fa / 2, 2) + Math.Pow(aa[0], 2)));
    }
}
