using System;

public struct Student : IComparable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Student(string firstName, string lastName)
        : this()
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public override string ToString()
    {
        return string.Format("{0} {1}", this.FirstName, this.LastName);
    }

    public int CompareTo(object obj)
    {
        var other = (Student)obj;

        if (this.LastName.CompareTo(other.LastName) == 0)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }

        return this.LastName.CompareTo(other.LastName);
    }
}