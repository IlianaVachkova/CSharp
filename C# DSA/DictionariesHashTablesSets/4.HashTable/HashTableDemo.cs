using System;

public class HashTableDemo
{
    public static void Main()
    {
        HashTable<string, int> marks = new HashTable<string, int>();
        marks.Add("Pesho", 6);
        marks.Add("Pesho", 2);
        marks.Add("Gosho", 3);
        marks.Add("Petranka", 2);
        marks.Add("Stoqnka", 5);
        marks.Add("Kirilka", 4);
        marks.Remove("Stoqnka");
        marks["Pesho"] = 3;

        foreach (var item in marks)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }

        Console.WriteLine(marks.Find("Pesho"));
        Console.WriteLine(marks["Pesho"]);
        Console.WriteLine();

        marks.Clear();

        marks.Add("Pesho", 6);
        marks.Add("Pesho", 2);
        marks.Add("Gosho", 3);
        marks.Add("George", 2);
        marks.Add("Stanley", 5);
        marks.Add("Kate", 4);
        marks.Remove("Stanley");
        marks["Pesho"] = 3;

        foreach (var item in marks)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }

        Console.WriteLine(marks.Find("Pesho"));
        Console.WriteLine(marks["Pesho"]);
    }
}