using System;
using AbstractFactory.Products.Chairs;
using AbstractFactory.Products.CoffeeTable;
using AbstractFactory.Products.Sofas;

namespace AbstractFactory.Factories.FurnitureFactory;

public class VictorianFurnitureFactory : IFurnitureFactory
{
    IChair IFurnitureFactory.CreateChair() => new VictorianChair();
    ICoffeeTable IFurnitureFactory.CreateCoffeeTable() => new VictorianCoffeTable();
    ISofa IFurnitureFactory.CreateSofa() => new ArtisticSofa();
}
