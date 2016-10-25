/*
    Using the same input as above print all students whose first name is before 
    their last name lexicographically. Use a LINQ/Stream query. Print them in order 
    of appearance.
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

            students.Add(new Student(lineAsArr[0], lineAsArr[1]));

            line = Console.ReadLine();
        }

        var result = students
            .Where(st => st.LastName.CompareTo(st.FirstName) == 1)
            .ToList();

        foreach (var student in result)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}

public class Student
{
    public Student(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}


