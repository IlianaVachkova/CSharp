using System;
using System.Collections.Generic;
using System.Text;

public class Course
{
    private string name;
    private IList<Student> students;

    public Course(string name)
    {
        this.Name = name;
        this.students = new List<Student>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                    "Name of course cannot be null!");
            }

            this.name = value;
        }
    }

    public IList<Student> Students
    {
        get
        {
            IList<Student> studentsCopy =
                new List<Student>(this.students);

            return studentsCopy;
        }
    }

    public void AddStudent(Student student)
    {
        if (this.Students.Count < 30)
        {
            this.students.Add(student);
        }
        else
        {
            Console.WriteLine(
                "Sorry you cannot participate this course, because it's full!");
        }
    }

    public void RemoveStudent(Student student)
    {
        this.students.Remove(student);
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendFormat("Course: {0}", this.name);
        if (this.students.Count > 0)
        {
            result.AppendLine();
            result.Append("Students: ");
            result.Append(string.Join("; ", this.students));
        }

        return result.ToString();
    }
}