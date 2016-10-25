using System;
using System.Text;

public class Animal : ISound
{
    private string name;
    private string age;
    private string gender;

    public Animal()
    {
    }

    public Animal(string name, string age)
        : this()
    {
        this.Name = name;
        this.Age = age;
    }

    public Animal(string name, string age, string gender)
        : this(name, age)
    {
        this.Gender = gender;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }

            this.name = value;
        }
    }

    public string Age
    {
        get
        {
            return this.age;
        }

        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            else if (int.Parse(value) < 0)
            {
                throw new ArgumentException("Invalid input!");
            }

            this.age = value;
        }
    }

    public string Gender
    {
        get
        {
            return this.gender;
        }

        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }

            this.gender = value;
        }
    }

    public virtual string PorduceSound()
    {
        return "Not implemented!";
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        result.AppendFormat("{0} {1} {2}", this.Name, this.Age, this.Gender)
            .AppendLine()
            .Append(this.PorduceSound());

        return result.ToString();
    }
}