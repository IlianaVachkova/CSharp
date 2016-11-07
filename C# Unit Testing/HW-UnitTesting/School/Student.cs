using System;

public class Student
{
    private string name;
    private int number;

    public Student(string name, int number)
    {
        this.Name = name;
        this.Number = number;
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
                    "Name of student cannot be null!");
            }

            this.name = value;
        }
    }

    public int Number
    {
        get
        {
            return this.number;
        }

        private set
        {
            if (value < 10000 || value > 99999)
            {
                throw new ArgumentOutOfRangeException(
                    "Unique number of the student must be in the range [10 000...99 999]");
            }

            this.number = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Student: {0}, Number: {1}",
            this.Name, this.Number);
    }
}