using System;
using FactoryPattern.Products;

namespace FactoryPattern.Creators;

public class WaterLogistics : Logistics
{
    public override Transport CreateTransport()
    {
        return new ShipProduct();
    }
}
