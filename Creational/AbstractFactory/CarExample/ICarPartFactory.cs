using AbstractFactory.CarExample.CarPart;

namespace AbstractFactory.CarExample;

/// <summary>
/// A factory that creates car parts for a specific type of car.
/// In this case, named it a factory. In practice it may be called a builder or service.
/// This pattern ensures that all components created from a factory are related to each other.
/// </summary>
public interface ICarPartFactory
{
    /// <summary>
    /// Creates an <see cref="IEngine"/> for a specific car.
    /// </summary>
    /// <returns>An <see cref="IEngine"/> for a specific car.</returns>
    IEngine CreateEngine();

    /// <summary>
    /// Creates an <see cref="ITransmission"/> for a specific car.
    /// </summary>
    /// <returns>An <see cref="ITransmission"/> for a specific car.</returns>
    ITransmission CreateTransmission();

    /// <summary>
    /// Creates an <see cref="ICupHolder"/> for a specific car.
    /// </summary>
    /// <returns>An <see cref="ICupHolder"/> for a specific car.</returns>
    ICupHolder CreateCupHolder();
}
