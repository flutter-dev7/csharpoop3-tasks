using System;

namespace task1;

public class Teacher : Person
{
    public Teacher(string name) : base(name)
    {
    }
    public void Explain()
    {
        System.Console.WriteLine($"The {Name} is explaining");
    }
}
