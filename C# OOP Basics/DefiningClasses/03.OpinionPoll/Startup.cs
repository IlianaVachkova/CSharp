using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        List<Person> persons = new List<Person>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] nameAge = Console.ReadLine().Split();
            persons.Add(new Person(nameAge[0], int.Parse(nameAge[1])));
        }

        var result = persons
            .Where(p => p.age > 30)
            .OrderBy(p => p.name)
            .ToArray();

        foreach (var person in result)
        {
            Console.WriteLine("{0} - {1}", person.name, person.age);
        }
    }
}
