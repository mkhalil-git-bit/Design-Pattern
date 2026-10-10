using System;

namespace FactoryPattern.Products;

public class TruckProduct : Transport
{
    public override void Delivery()
    {
        Console.WriteLine("Delivering by road on truck.");
    }
}
