namespace Command.HanoiExample.Model;

public class Rod
{
    public Stack<Disc> Discs { get; }

    public Rod(uint discs = 0)
    {
        Discs = new Stack<Disc>();
        for (uint disc = discs; disc > 0; disc--)
        {
            Discs.Push(new Disc(disc));
        }
    }
}
