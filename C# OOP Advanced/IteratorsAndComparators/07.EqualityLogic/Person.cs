using System;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;
            if (other == null)
            {
                return false;
            }

            if (this.CompareTo(other) == 0)
            {
                return true;
            }

            return false;
        }


        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Age ^ 23;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Name, this.Age);
        }
    }
}
