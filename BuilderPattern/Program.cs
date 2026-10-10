using BuilderPattern.Builders;
using BuilderPattern.Director;
using BuilderPattern.Product;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose house type: wooden / stone");
        string choice = Console.ReadLine();

        IHouseBuilder builder;

        if (choice?.ToLower() == "wooden")
            builder = new WoodenHouse();
        else
            builder = new StoneHouse();

        var engineer = new ConstructionEngineer(builder);
        House house = engineer.Construct();

        house.Show();
    }
}
