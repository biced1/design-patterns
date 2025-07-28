namespace Adapter.Blueprint;

public class Data
{
    public Data(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Readonly name represented as a string.
    /// </summary>
    public string Name { get; }
}
