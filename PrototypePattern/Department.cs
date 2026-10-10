using System;

namespace PrototypePattern;

public class Department
{
    public string DeptName { get; set; }

    public Department(string name)
    {
        DeptName = name;
    }

    public Department DeepCopy()
    {
        return new Department(this.DeptName);
    }
}

