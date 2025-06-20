using System;

namespace DesignPatterns.Factory.Blueprint;

public class ProductB : IProduct
{
    public void DoStuff()
    {
        Console.WriteLine("Doing some different stuff in product B");
    }

    public string GetNickname()
    {
        return "Ace";
    }
}