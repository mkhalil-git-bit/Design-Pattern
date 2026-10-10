using System;
using AbstractFactory.Products.CoffeeTable;

namespace AbstractFactory.Products.Sofas;

public class VictorianSofa : ISofa
{
    public void LieOn()
    {
        Console.WriteLine("Lying on Victorian Sofa");
    }
}
