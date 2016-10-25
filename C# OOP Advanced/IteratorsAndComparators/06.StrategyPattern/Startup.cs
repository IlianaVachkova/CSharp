using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class Startup
    {
        public static void Main()
        {
            SortedSet<Person> peopleByName = new SortedSet<Person>(new NameComparer());
            SortedSet<Person> peopleByAge = new SortedSet<Person>(new AgeComparer());

            int peopleCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < peopleCount; i++)
            {
                string[] personInfo = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                peopleByName.Add(person);
                peopleByAge.Add(person);
            }

            foreach (Person person in peopleByName)
            {
                Console.WriteLine(person);
            }

            foreach (Person person in peopleByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}
