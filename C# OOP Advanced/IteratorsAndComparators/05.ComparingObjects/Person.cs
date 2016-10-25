using System;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Town { get; private set; }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return -1;
            }
            else if (this.Age.CompareTo(other.Age) != 0)
            {
                return -1;
            }
            else if (this.Town.CompareTo(other.Town) != 0)
            {
                return -1;
            }

            return 1;
        }
    }
}
