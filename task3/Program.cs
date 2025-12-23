using task3;

Console.Write("Enter Dog Name: ");
string name = Console.ReadLine()!;
Dog dog = new Dog();
dog.SetName(name);
string dogName = dog.GetName();
System.Console.WriteLine(dogName);
dog.Eat();