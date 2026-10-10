using System;

namespace AbstractFactory.Products.Chairs;

public class ModernChair : IChair
{
     public void HasLegs()
    {
        Console.WriteLine("The Modern Chair has four legs.");
    }

    public void SitOns()
    {
        Console.WriteLine("The Modern Chair has modern legacy seat.");
    }
}
