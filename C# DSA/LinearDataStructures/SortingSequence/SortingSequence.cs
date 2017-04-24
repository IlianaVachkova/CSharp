using System;
using System.Collections.Generic;
using System.Linq;

public class SortingSequence
{
    public static void Main()
    {
        List<int> sequence = ReadSequenceFromConsole();

        Console.WriteLine(string.Join(" ", sequence.OrderBy(x=>x)));

        sequence.Sort();
        Console.WriteLine(string.Join(" ", sequence));
    }

    public static List<int> ReadSequenceFromConsole()
    {
        List<int> sequence = new List<int>();
        string input = Console.ReadLine();
        while (input != string.Empty)
        {
            int number = int.Parse(input);
            sequence.Add(number);
            input = Console.ReadLine();
        }

        return sequence;
    }
}
