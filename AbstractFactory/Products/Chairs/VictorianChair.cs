using System;

namespace AbstractFactory.Products.Chairs;

public class VictorianChair : IChair
{
    public void HasLegs()
    {
        Console.WriteLine("The Victorian Chair has four legs.");
    }

    public void SitOns()
    {
        Console.WriteLine("The Victorian Chair has old legacy seat.");
    }
}
