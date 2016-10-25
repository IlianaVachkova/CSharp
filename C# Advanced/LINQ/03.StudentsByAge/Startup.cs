/*
    Write a LINQ/Stream query that finds the first name and last name 
    of all students with age between 18 and 24. The query should return 
    the first name, last name and age. Print them in order of appearance.
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
            students.Add(new Student(lineAsArr[0], lineAsArr[1], int.Parse(lineAsArr[2])));

            line = Console.ReadLine();
        }

        var result = students
            .Where(st => (st.Age >= 18 && st.Age <= 24))
            .ToList();

        foreach (var student in result)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Age);
        }
    }
}

public class Student
{
    public Student(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }
}

