/*
    Print all students with phones in Sofia (starting with 02 / +3592). Use LINQ.
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
            .Where(st => (st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592")))
            .ToList();

        foreach (var student in result)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}

public class Student
{
    public Student(string firstName, string lastName, string phone)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Phone = phone;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Phone { get; set; }
}

