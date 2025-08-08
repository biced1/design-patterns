namespace Adapter.CalculatorExample;

/// <summary>
/// Service that calculates the area of various 2D and 3D objects
/// The client doesn't need to know about the adapter, just the end functionality
/// </summary>
public interface IAreaCalculator
{
    double CalculateCircle(double radius);

    /// <summary>
    /// Calculates the area of a circle
    /// </summary>
    /// <param name="radius"></param>
    /// <returns></returns>
    double CalculateCircle(int radius);

    double CalculateSphere(double radius);

    double CalculateSphere(int radius);

    double CalculateTriangle(double width, double height);

    double CalculateTriangle(int width, int height);

    double CalculatePyramid(double length, double width, double height);

    double CalculatePyramid(int length, int width, int height);
}
