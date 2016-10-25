using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> people;

    public Family()
    {
        this.people = new List<Person>();
    }

    public void AddMember(Person member)
    {
        people.Add(member);
    }

    public Person GetOldestMember()
    {
        var maxAge = people
            .Max(m => m.Age);
        var person = people
            .Where(m => m.Age == maxAge)
            .FirstOrDefault();

        return person;
    }
}
