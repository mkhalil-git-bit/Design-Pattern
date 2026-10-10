using System;
using AbstractFactory.Products.Chairs;
using AbstractFactory.Products.CoffeeTable;
using AbstractFactory.Products.Sofas;

namespace AbstractFactory.Factories.FurnitureFactory;

public class ModernFurnitureFactory : IFurnitureFactory
{

    IChair IFurnitureFactory.CreateChair() => new ModernChair();

    ICoffeeTable IFurnitureFactory.CreateCoffeeTable() => new ModernCoffeeTable();
    ISofa IFurnitureFactory.CreateSofa() => new ModernSofa();


}
