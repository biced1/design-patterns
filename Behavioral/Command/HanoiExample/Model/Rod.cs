namespace Command.HanoiExample.Model;

/// <summary>
/// A rod that contains <see cref="Disc"/>(s).
/// </summary>
public class Rod
{
    /// <summary>
    /// The stack of <see cref="Disc"/>(s) on this rod.
    /// </summary>
    public Stack<Disc> Discs { get; }
    
    /// <summary>
    /// The position of this rod.
    /// Either left, middle or right.
    /// </summary>
    public RodPosition Position { get; }

    /// <summary>
    /// Creates a new Rod.
    /// </summary>
    /// <param name="position">The position of this rod.
    /// Either left, middle or right.</param>
    /// <param name="discs">The number of <see cref="Disc"/>(s) to add to the rod.</param>
    public Rod(RodPosition position, uint discs = 0)
    {
        Position = position;
        Discs = new Stack<Disc>();
        for (uint disc = discs; disc > 0; disc--)
        {
            Discs.Push(new Disc(disc));
        }
    }
}
