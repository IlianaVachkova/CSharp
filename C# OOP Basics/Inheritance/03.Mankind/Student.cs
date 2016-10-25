using System;
using System.Text;

public class Student : Humman
{
    private string facNumber;

    public Student(string firstName, string lastName, string facNumber)
        : base(firstName, lastName)
    {
        this.FacNumber = facNumber;
    }

    public string FacNumber
    {
        get
        {
            return this.facNumber;
        }

        private set
        {
            if (value.Length < 5 || value.Length > 10)
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            else
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetterOrDigit(value[i]))
                    {
                        throw new ArgumentException("Invalid faculty number!");
                    }
                }
            }

            this.facNumber = value;
        }
    }

    public override string FirstName
    {
        get
        {
            return base.FirstName;
        }

        set
        {
            if (value.Length < 4)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }

            base.FirstName = value;
        }
    }

    public override string LastName
    {
        get
        {
            return base.LastName;
        }

        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }

            base.LastName = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(base.ToString())
            .AppendFormat("Faculty number: {0}", this.FacNumber);

        return sb.ToString().Trim();
    }
}