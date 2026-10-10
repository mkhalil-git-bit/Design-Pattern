using System;
using AbstractFactory.Products.Chairs;
using AbstractFactory.Products.CoffeeTable;
using AbstractFactory.Products.Sofas;

namespace AbstractFactory.Factories.FurnitureFactory;

public class ArtDecoFurnitureFactory : IFurnitureFactory
{
    IChair IFurnitureFactory.CreateChair() => new ArtisticChair();
    ICoffeeTable IFurnitureFactory.CreateCoffeeTable() => new ArtisticCoffeeTable();
    ISofa IFurnitureFactory.CreateSofa() => new ArtisticSofa();
}
