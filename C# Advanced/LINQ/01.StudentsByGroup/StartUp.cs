/*
    Print all students from group number 2. Use a LINQ/Stream query. Order the students by FirstName.

        Input	                Output
        Sara Mills 1            Andrew Gibson 
        Andrew Gibson 2         Andrew Carter
        Craig Ellis 1           Steven Cole
        Steven Cole 2 
        Andrew Carter 2
        END	
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        string line = Console.ReadLine();
        List<Student> students = new List<Student>();

        while (line != "END")
        {
            string[] lineAsArr = line.Split(' ');
            students.Add(new Student(lineAsArr[0], lineAsArr[1], lineAsArr[2]));

            line = Console.ReadLine();
        }

        var result = students
            .Where(st => st.Group == "2")
            .OrderBy(st => st.FirstName)
            .ToList();

        foreach (var student in result)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}

public class Student
{
    public Student(string firstName, string lastName, string group)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Group = group;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Group { get; set; }
}

