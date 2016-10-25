/*
    Using the lambda expressions with LINQ/Stream query syntax sort the students first by 
    last name in ascending order and then by first name in descending order.
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
            .OrderBy(st => st.LastName)
            .ThenByDescending(st => st.FirstName)
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
