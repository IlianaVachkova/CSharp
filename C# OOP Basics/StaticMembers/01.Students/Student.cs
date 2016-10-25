public class Student
{
    public static int instancesCount = 0;

    public Student(string name)
    {
        this.Name = name;
        instancesCount++;
    }

    public string Name { get; private set; }
}