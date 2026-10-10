using System;

namespace BuilderPattern.Product;

public class House
{
    public string Walls { get; set; }
    public string Roof { get; set; }
    public string Doors { get; set; }
    public string Windows { get; set; }
    public string Garage { get; set; }

    public void Show()
    {
        Console.WriteLine($"House with {Walls}, {Roof}, {Doors}, {Windows}, and {Garage}.");
    }
}
