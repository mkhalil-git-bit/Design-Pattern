using System;
using AbstractFactory.Products.CoffeeTable;

namespace AbstractFactory.Products.Sofas;

public class ArtisticSofa : ISofa
{
    public void LieOn()
    {
        Console.WriteLine("Lying on victorian Sofa");
    }
}
