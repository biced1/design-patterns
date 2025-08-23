namespace Command.HanoiExample.Model;

public class GameState(Rod leftRod, Rod middleRod, Rod rightRod)
{
    public Rod LeftRod { get; } = leftRod;
    public Rod MiddleRod { get; } = middleRod;
    public Rod RightRod { get; } = rightRod;
    public int TotalDiscs { get; } = leftRod.Discs.Count + middleRod.Discs.Count + rightRod.Discs.Count;
}
