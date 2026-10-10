using System;
using AbstractFactory.Factories.FurnitureFactory;
using AbstractFactory.Products.Chairs;
using AbstractFactory.Products.CoffeeTable;

namespace AbstractFactory.Client;

public class FurnitureStore
{
    private readonly IChair _chair;
    private readonly ICoffeeTable _coffeeTable;
    private readonly ISofa _sofa;

    public FurnitureStore(IFurnitureFactory furnitureFactory)
    {
        _chair = furnitureFactory.CreateChair();
        _coffeeTable = furnitureFactory.CreateCoffeeTable();
        _sofa = furnitureFactory.CreateSofa();
    }

    public void Showroom()
    {
        _chair.HasLegs();
        _chair.SitOns();
        _coffeeTable.PlaceItems();
        _sofa.LieOn();
    }
}
