using System;

public class ShcoolExample
{
    public static void Main()
    {
        var kpk = new Course("KPK");
        var pesho = new Student("Pesho", 10000);
        var gosho = new Student("Gosho", 10100);
        kpk.AddStudent(pesho);
        kpk.AddStudent(gosho);

        var actual = kpk.ToString();
        var expected = "Course: KPK\r\nStudents: Student: Pesho, Number: 10000; Student: Gosho, Number: 10100";
        Console.WriteLine(expected);
        Console.WriteLine();
        Console.WriteLine(actual);
    }
}