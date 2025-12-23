using System;

namespace task1;

public class Person
{
    public string Name { get; set; } = string.Empty;
    public Person(string name)
    {
        Name = name;
    }
    public override string ToString()
    {
        return $"Name: {Name}";
    }
}
