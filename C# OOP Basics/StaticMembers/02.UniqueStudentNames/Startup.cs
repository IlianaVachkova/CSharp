using System;

public class Startup
{
    public static void Main()
    {
        string name = Console.ReadLine();
        StudentGroup students = new StudentGroup();
        while (name != "End")
        {
            Student student = new Student(name);
            students.AddStudent(student);
            name = Console.ReadLine();
        }

        Console.WriteLine(StudentGroup.uniqueNames);
    }
}
