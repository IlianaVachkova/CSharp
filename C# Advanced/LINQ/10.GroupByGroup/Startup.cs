/*
    Create a class Person. It should consists of properties : name and group (String, Integer).
    Write a program that extracts all persons (students), grouped by GroupName and then prints them 
    on the console. Print all group names along with the students in each group. Use the group by 
    LINQ/Stream operators. You will be given an input on the console.

    Output format : {group} - {name1}, {name2}, {name3}, ...

    Input	                        Output
    Ivaylo Petrov 10                3 - Stanimir Svilianov, Indje Kromidov
    Stanimir Svilianov 3            4 - Irina Balabanova
    Indje Kromidov 3                10 - Ivaylo Petrov
    Irina Balabanova 4
    END	
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public Person(string name, int group)
    {
        this.Name = name;
        this.Group = group;
    }

    public string Name { get; set; }

    public int Group { get; set; }
}

public class Startup
{
    static void Main()
    {
        List<Person> people = new List<Person>();
        string line = Console.ReadLine();

        while (line != "END")
        {
            string[] lineAsArr = line.Split(' ');
            string name = string.Format("{0} {1}", lineAsArr[0], lineAsArr[1]);

            people.Add(new Person(name, int.Parse(lineAsArr[2])));

            line = Console.ReadLine();
        }

        var groups = people
            .OrderBy(p => p.Group)
            .GroupBy(p => p.Group)
            .ToList();

        foreach (var group in groups)
        {
            Console.WriteLine(group.Key + " - " + string.Join(", ", group.Select(p => p.Name)));
        }
    }
}
