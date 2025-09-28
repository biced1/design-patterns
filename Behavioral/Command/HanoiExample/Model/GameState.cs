namespace Command.HanoiExample.Model;

/// <summary>
/// The game state for a Towers of Hanoi game.
/// </summary>
/// <param name="leftRod">The left rod, containing <see cref="Disc"/>(s).</param>
/// <param name="middleRod">The middle rod, containing <see cref="Disc"/>(s).</param>
/// <param name="rightRod">The right rod, containing <see cref="Disc"/>(s).</param>
public class GameState(Rod leftRod, Rod middleRod, Rod rightRod)
{
    /// <summary>
    /// The left rod, containing <see cref="Disc"/>(s).
    /// </summary>
    public Rod LeftRod { get; } = leftRod;

    /// <summary>
    /// The middle rod, containing <see cref="Disc"/>(s).
    /// </summary>
    public Rod MiddleRod { get; } = middleRod;

    /// <summary>
    /// The right rod, containing <see cref="Disc"/>(s).
    /// </summary>
    public Rod RightRod { get; } = rightRod;

    /// <summary>
    /// The total number of discs in the game.
    /// </summary>
    public int TotalDiscs { get => LeftRod.Discs.Count + MiddleRod.Discs.Count + RightRod.Discs.Count; }
}
