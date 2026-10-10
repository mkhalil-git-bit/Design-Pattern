using System;
using BuilderPattern.Product;

namespace BuilderPattern.Builders;

public class WoodenHouse : IHouseBuilder
{
    private readonly House _house = new House();
    public void BuildDoors() => _house.Doors = "Wooden Doors";

    public void BuildGarage()=> _house.Garage = "Wooden Garage";

    public void BuildRoof()=> _house.Roof = "Wooden Roof";

    public void BuildWalls()=> _house.Walls = "Wooden Walls";

    public void BuildWindows()=> _house.Windows = "Wooden Windows";

    public House GetHouse() => _house;
}
