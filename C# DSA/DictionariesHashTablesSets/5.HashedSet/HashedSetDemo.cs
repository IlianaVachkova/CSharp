using System;

public class HashedSetDemo
{
    public static void Main()
    {
        HashedSet<string> names = new HashedSet<string>();
        names.Add("Pesho");
        names.Add("Pesho");
        names.Add("Gosho");
        names.Add("Doncho");
        names.Add("Niki");
        Console.WriteLine(names.Count);
        names.Remove("Pesho");
        names.Remove("Pesho");
        Console.WriteLine(names.Count);
        Console.WriteLine(names.Find("Pesho"));
        names.Clear();
        Console.WriteLine(names.Count);
    }
}