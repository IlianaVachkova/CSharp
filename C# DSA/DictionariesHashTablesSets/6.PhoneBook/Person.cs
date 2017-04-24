using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public string Town { get; set; }
    public string PhoneNumber { get; set; }

    public Person()
    { }

    public Person(string name, string town, string phoneNumber)
    {
        this.Name = name;
        this.Town = town;
        this.PhoneNumber = phoneNumber;
    }

    public override string ToString()
    {
        return this.Name + " | " + this.Town + " | " + this.PhoneNumber;
    }

    public override bool Equals(object obj)
    {
        var other = (Person)obj;
        if (this.Name == other.Name &&
            this.Town == other.Town &&
            this.PhoneNumber == other.PhoneNumber)
        {
            return true;
        }

        return false;
    }
}