using System;
using System.IO;
using System.Collections.Generic;

public class StudentsCoursesDemo
{
    public static void Main()
    {
        var reader = new StreamReader("..//..//students.txt");
        var courses = new SortedDictionary<string, SortedSet<Student>>();

        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            var tokens = line.Split(new char[]{'|', ' '}, 
                StringSplitOptions.RemoveEmptyEntries);
            var firstName = tokens[0].Trim();
            var lastName = tokens[1].Trim();
            var course = tokens[2].Trim();
            var student = new Student(firstName, lastName);
            if (!courses.ContainsKey(course))
            {
                var students = new SortedSet<Student>();
                students.Add(student);
                courses.Add(course, students);
            }
            else
            {
                courses[course].Add(student);
            }
        }

        foreach (var course in courses)
        {
            Console.Write("{0}: ", course.Key);
            Console.WriteLine(string.Join(", ", course.Value));
        }

        reader.Close();
    }
}