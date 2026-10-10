using System;
using FactoryPattern.Products;

namespace FactoryPattern.Creators;

public class RoadLogistics : Logistics
{
    public override Transport CreateTransport()
    {
        return new TruckProduct();
    }
}
