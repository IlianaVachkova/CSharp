namespace DefineClassPerson
{
    public class Person
    {
        public string name;
        public int age;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int newAge)
            :this()
        {
            this.age = newAge;
        }

        public Person(string newName, int newAge)
            :this(newAge)
        {
            this.name = newName;
        }
    }
}
