using System;
using BuilderPattern.Product;

namespace BuilderPattern.Builders;

public class StoneHouse : IHouseBuilder
{
    private readonly House _house = new House();
    public void BuildDoors() => _house.Doors = "Stone Doors";

    public void BuildGarage()=> _house.Garage = "Stone Garage";

    public void BuildRoof()=> _house.Roof = "Stone Roof";

    public void BuildWalls()=> _house.Walls = "Stone Walls";

    public void BuildWindows()=> _house.Windows = "Stone Windows";

    public House GetHouse() => _house;
}
