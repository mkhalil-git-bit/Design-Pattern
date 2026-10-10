using System;
using FactoryPattern.Products;

namespace FactoryPattern.Creators;

public abstract class Logistics
{
    public abstract Transport CreateTransport();
    public void DoSomething()
    {
        var vehicle = CreateTransport();
        vehicle.Delivery();
    }
}
