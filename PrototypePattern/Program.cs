using System;
using PrototypePattern;

class Program
{
    static void Main()
    {
        var registry = new PrototypeManager();

        // Register base prototypes
        registry.AddPrototype("developer", new Employee("Default Dev", new Department("IT")));
        registry.AddPrototype("hr", new Employee("Default HR", new Department("HR")));

        // Clone developer prototype
        var emp1 = (Employee)registry.GetClone("developer");
        emp1.Name = "John";

        // Clone HR prototype
        var emp2 = (Employee)registry.GetClone("hr");
        emp2.Name = "Alice";

        emp1.ShowDetails();  // John works in IT
        emp2.ShowDetails();  // Alice works in HR
    }
}
