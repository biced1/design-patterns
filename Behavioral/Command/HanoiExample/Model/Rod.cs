namespace Command.HanoiExample.Model;

public class Rod
{
    public Stack<Disc> Discs { get; }
    public RodPosition Position { get; }

    public Rod( RodPosition position, uint discs = 0)
    {
        Position = position;
        Discs = new Stack<Disc>();
        for (uint disc = discs; disc > 0; disc--)
        {
            Discs.Push(new Disc(disc));
        }
    }
}
