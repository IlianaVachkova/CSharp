using System;
using System.Text;

public abstract class Humman
{
    private string firstName;
    private string lastName;

    public Humman(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public virtual string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }

            this.firstName = value;
        }
    }

    public virtual string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            }

            this.lastName = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("First Name: {0}", this.FirstName)
            .AppendLine()
            .AppendFormat("Last Name: {0}", this.LastName)
            .AppendLine();

        return sb.ToString();
    }
}