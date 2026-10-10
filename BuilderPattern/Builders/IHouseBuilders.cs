using System;

namespace BuilderPattern.Product;

public interface IHouseBuilder
{
    void BuildWalls();
    void BuildRoof();
    void BuildDoors();
    void BuildWindows();
    void BuildGarage();
    House GetHouse();
}

