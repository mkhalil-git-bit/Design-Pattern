using System;

namespace AbstractFactory.Products.Chairs;

public class ArtisticChair : IChair
{
    public void HasLegs()
    {
        Console.WriteLine("The Artistic Chair has four legs.");
    }

    public void SitOns()
    {
        Console.WriteLine("The Artistic Chair has artistic seat.");
    }
}
