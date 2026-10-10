using System;

namespace PrototypePattern;

public class Employee : IPrototype
{
    public string Name { get; set; }
    public Department Dept { get; set; }

    public Employee(string name, Department dept)
    {
        Name = name;
        Dept = dept;
    }

    public IPrototype Clone()
    {
        return new Employee(this.Name, this.Dept.DeepCopy()); // Deep clone
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{Name} works in {Dept.DeptName}");
    }
}
