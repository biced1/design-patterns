namespace Command.HanoiExample.Model;

/// <summary>
/// A disc of a specific size.
/// </summary>
/// <param name="size">Size of this disc.</param>
public class Disc(uint size)
{
    /// <summary>
    /// Size of this disc.
    /// </summary>
    public uint Size { get; } = size;
}
