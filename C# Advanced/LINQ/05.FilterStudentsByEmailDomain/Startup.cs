/*
    Print all students that have email @gmail.com. Use LINQ/Stream API. 
    Print the in order of appearance.
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
            string[] emailDomain = lineAsArr[2].Split('@');
            students.Add(new Student(lineAsArr[0], lineAsArr[1], emailDomain[1]));

            line = Console.ReadLine();
        }

        var result = students
            .Where(st => st.EmailDomain == "gmail.com")
            .ToList();

        foreach (var student in result)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
    }
}

public class Student
{
    public Student(string firstName, string lastName, string emailDomain)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.EmailDomain = emailDomain;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string EmailDomain { get; set; }
}

