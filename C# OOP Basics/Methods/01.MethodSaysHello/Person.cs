public class Person
{
    public string name;

    public Person(string name)
    {
        this.name = name;
    }

    public string SayHello()
    {
        return this.name + " says \"Hello\"!";
    }
}