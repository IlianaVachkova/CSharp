using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        string name = Console.ReadLine();
        List<Student> students = new List<Student>();
        while (name!="End")
        {
            students.Add(new Student(name));
            name = Console.ReadLine();
        }

        Console.WriteLine(Student.instancesCount);
    }
}
