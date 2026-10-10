using System;

namespace AbstractFactory.Products.CoffeeTable;

public class ModernCoffeeTable : ICoffeeTable
{
    public void PlaceItems()
    {
        Console.WriteLine("Placing items on modern coffee table");
    }
}
