using task1;

Person[] people = new Person[3];
Console.Write("Enter name of student 1: ");
people[0] = new Student(Console.ReadLine()!);
Console.Write("Enter name of student 2: ");
people[1] = new Student(Console.ReadLine()!);
Console.Write("Enter name of teacher: ");
people[2] = new Student(Console.ReadLine()!);
foreach (var item in people)
{
    System.Console.WriteLine(item.ToString());
}
Student student = new Student("Alisher");
student.Study();
Teacher teacher = new Teacher("Cuhrob");
teacher.Explain();