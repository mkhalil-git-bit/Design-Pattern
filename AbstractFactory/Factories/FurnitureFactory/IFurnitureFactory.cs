using System;
using AbstractFactory.Products.Chairs;
using AbstractFactory.Products.CoffeeTable;

namespace AbstractFactory.Factories.FurnitureFactory;

public interface IFurnitureFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
    ICoffeeTable CreateCoffeeTable();
}
