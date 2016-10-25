using System.Collections.Generic;

public class StudentGroup
{
    private HashSet<Student> students;
    public static int uniqueNames = 0;

    public StudentGroup()
    {
        this.students = new HashSet<Student>();
    }

    public void AddStudent(Student student)
    {
        this.students.Add(student);
        uniqueNames = students.Count;
    }
}