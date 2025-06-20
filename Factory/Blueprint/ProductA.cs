namespace DesignPatterns.Factory.Blueprint;

public class ProductA : IProduct
{
    public void DoStuff()
    {
        Console.WriteLine("Doing some stuff in product A");
    }

    public string GetNickname()
    {
        return "Sport";
    }
}