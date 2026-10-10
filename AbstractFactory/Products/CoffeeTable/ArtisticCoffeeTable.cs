using System;

namespace AbstractFactory.Products.CoffeeTable;

public class ArtisticCoffeeTable : ICoffeeTable
{
    public void PlaceItems()
    {
        Console.WriteLine("Placing items on artistic coffee table");
    }
}
