using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class Startup
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            string line = Console.ReadLine();
            while (line != "END")
            {
                string[] personInfo = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                people.Add(new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]));

                line = Console.ReadLine();
            }

            int personInIndex = int.Parse(Console.ReadLine()) - 1;
            Person searchedPerson = people[personInIndex];

            int equalPeople = people.Count(p=>p.CompareTo(searchedPerson)==1);
            int notequalPeople = people.Count(p=>p.CompareTo(searchedPerson)==-1);
            int totalPeople = people.Count;

            if (equalPeople==1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", equalPeople, notequalPeople, totalPeople);
            }
        }
    }
}
