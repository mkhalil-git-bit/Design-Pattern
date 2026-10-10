using System;

namespace FactoryPattern.Products;

public class ShipProduct : Transport
{
    public override void Delivery()
    {
        Console.WriteLine("Delivering by water on ship.");
    }
}
