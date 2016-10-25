using System;

public class Student : IEquatable<Student>
{
    public Student(string name)
    {
        this.Name = name;
    }

    public string Name { get; private set; }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

    public bool Equals(Student other)
    {
        return this.Name.Equals(other.Name);
    }
}