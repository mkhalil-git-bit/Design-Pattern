using FactoryPattern.Creators;
using FactoryPattern.Products;

public class Program
{
    public static void Main(string[] args)
    {
        Logistics logistics;
        Console.WriteLine("Please enter your mode of transport.");
        var input = int.Parse(Console.ReadLine());
        if (input == 1)
        {
            logistics = new RoadLogistics();
        }
        else
        {
            logistics = new WaterLogistics();
        }
        logistics.DoSomething();
    }
}