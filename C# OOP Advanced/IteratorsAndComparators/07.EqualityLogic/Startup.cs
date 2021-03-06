﻿using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class Startup
    {
        public static void Main()
        {
            SortedSet<Person> peopleSet = new SortedSet<Person>();
            HashSet<Person> peopleHash = new HashSet<Person>();

            int peopleCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < peopleCount; i++)
            {
                string[] personInfo = Console.ReadLine().Split();

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);

                peopleSet.Add(person);
                peopleHash.Add(person);
            }

            Console.WriteLine(peopleSet.Count);
            Console.WriteLine(peopleHash.Count);
        }
    }
}
