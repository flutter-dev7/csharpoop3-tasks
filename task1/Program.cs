using task1;

Person[] people = new Person[3];
Console.Write("Enter name of student 1: ");
Student student = new Student(Console.ReadLine()!);
people[0] = student;
Console.Write("Enter name of student 2: ");
Student student2 = new Student(Console.ReadLine()!);
people[1] = student2;
Console.Write("Enter name of teacher: ");

Teacher teacher = new Teacher(Console.ReadLine()!);
people[2] = teacher;
foreach (var item in people)
{
    System.Console.WriteLine(item.ToString());
}
student.Study();
student2.Study();
teacher.Explain();