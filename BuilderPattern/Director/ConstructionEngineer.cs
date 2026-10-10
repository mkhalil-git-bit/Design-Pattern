using System;
using BuilderPattern.Product;

namespace BuilderPattern.Director;

public class ConstructionEngineer
{
    private readonly IHouseBuilder _builder;

    public ConstructionEngineer(IHouseBuilder builder)
    {
        _builder = builder;
    }

    public House Construct()
    {
        _builder.BuildWalls();
        _builder.BuildRoof();
        _builder.BuildDoors();
        _builder.BuildWindows();
        _builder.BuildGarage();

        return _builder.GetHouse();
    }
}
