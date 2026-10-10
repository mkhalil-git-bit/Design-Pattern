using System;
using AbstractFactory.Products.CoffeeTable;

namespace AbstractFactory.Products.Sofas;

public class ModernSofa : ISofa
{
    public void LieOn()
    {
        Console.WriteLine("Using Modern Sofa");
    }
}
