using System;
using System.Collections.Generic;

public class SeverseSequence
{
    public static void Main()
    {
        List<int> reversedSequence = new List<int>();
        Stack<int> sequence = ReadSequenceFromConsole();
        int seqCount = sequence.Count;

        for (int i = 0; i < seqCount; i++)
        {
            int number = sequence.Pop();
            reversedSequence.Add(number);
        }

        Console.WriteLine(string.Join(" ", reversedSequence));
    }

    public static Stack<int> ReadSequenceFromConsole()
    {
        Stack<int> sequence = new Stack<int>();
        string input = Console.ReadLine();
        while (input !=string.Empty)
        {
            int number = int.Parse(input);
            sequence.Push(number);
            input = Console.ReadLine();
        }

        return sequence;
    }
}
