using System;
using System.Collections.Generic;
using System.Text;

public class School
{
    private string name;
    private IList<Student> students;
    private IList<Course> courses;

    public School(string name)
    {
        this.Name = name;
        this.students = new List<Student>();
        this.courses = new List<Course>();
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

    public IList<Course> Courses
    {
        get
        {
            IList<Course> coursesCopy =
                new List<Course>(this.courses);

            return coursesCopy;
        }
    }

    public void AddStudent(Student student)
    {
        this.students.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        this.students.Remove(student);
    }

    public void AddCourse(Course student)
    {
        this.courses.Add(student);
    }

    public void RemoveCourse(Course student)
    {
        this.courses.Remove(student);
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendFormat("School: {0}", this.name);
        result.AppendLine();
        result.Append("Students: ");
        result.Append(string.Join("; ", this.students));
        result.AppendLine();
        result.Append("Courses: ");
        result.Append(string.Join("; ", this.courses));
        result.AppendLine();

        return result.ToString();
    }
}