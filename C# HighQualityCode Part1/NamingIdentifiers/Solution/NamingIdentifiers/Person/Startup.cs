public class PersonExample
{
    public static void Main()
    {
        PersonExample person = new PersonExample();
        person.MakePerson(23);
    }

    public void MakePerson(int age)
    {
        Person human = new Person();
        human.Age = age;

        if (age % 2 == 0)
        {
            human.Name = "Pesho";
            human.Sex = Sex.Male;
        }
        else
        {
            human.Name = "Spaska";
            human.Sex = Sex.Female;
        }
    }
}