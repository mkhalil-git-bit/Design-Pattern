using AbstractFactory.Client;
using AbstractFactory.Factories.FurnitureFactory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose furniture style: modern / victorian / artistic");
        string choice = Console.ReadLine();

        IFurnitureFactory factory;

        if (choice?.ToLower() == "modern")
            factory = new ModernFurnitureFactory();
        else if(choice?.ToLower() == "victorian")
            factory = new VictorianFurnitureFactory();
            else
            factory = new ArtDecoFurnitureFactory();

        var store = new FurnitureStore(factory);
        store.Showroom();
    }
}
