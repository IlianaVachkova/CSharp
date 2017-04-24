using System;

public class BiDictionaryDemo
{
    public static void Main()
    {
        var biDictionary = new BiDictionary<int, string, int>();
        biDictionary.Add(3, "da", 3);
        biDictionary.Add(2, "da", 5);
        biDictionary.Add(1, "da", 4);
        biDictionary.Add(3, "da", 5);
        Console.WriteLine(biDictionary.ContainsKey("da"));
        Console.WriteLine(biDictionary.GetValuesByKey("da"));
        Console.WriteLine(biDictionary.GetValuesByKeys(3, "da"));
    }
}