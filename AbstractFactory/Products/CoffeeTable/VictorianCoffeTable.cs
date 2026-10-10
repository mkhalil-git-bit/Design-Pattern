using System;

namespace AbstractFactory.Products.CoffeeTable;

public class VictorianCoffeTable : ICoffeeTable
{
    public void PlaceItems()
    {
        Console.WriteLine("Placing items on victorian coffee table");
    }
}
