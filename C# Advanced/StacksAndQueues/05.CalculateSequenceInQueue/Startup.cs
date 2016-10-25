/*
    We are given the following sequence of numbers:
        •	S1 = N
        •	S2 = S1 + 1
        •	S3 = 2*S1 + 1
        •	S4 = S1 + 2
        •	S5 = S2 + 1
        •	S6 = 2*S2 + 1
        •	S7 = S2 + 2
        •	…
    Using the Queue<T> class, write a program to print its first 50 members for given N. Examples:
    Input:	    Output:
    2	        2 3 5 4 4 7 5 6 11 7 5 9 6 …
    -1	        -1 0 -1 1 1 1 2 …
    1000	    1000 1001 2001 1002 1002 2003 1003 …
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Queue <long> firstElOfSequence = new Queue<long>();
        Queue<long> partialElOfSequence = new Queue<long>();
        long elementInFormula = 0;

        firstElOfSequence.Enqueue(n);
        partialElOfSequence.Enqueue(n);

        for (int i = 0; i < 16; i ++)
        {
            elementInFormula = partialElOfSequence.Dequeue();

            firstElOfSequence.Enqueue(elementInFormula + 1);
            partialElOfSequence.Enqueue(elementInFormula + 1);

            firstElOfSequence.Enqueue(2 * elementInFormula + 1);
            partialElOfSequence.Enqueue(2 * elementInFormula + 1);

            firstElOfSequence.Enqueue(elementInFormula + 2);
            partialElOfSequence.Enqueue(elementInFormula + 2);
        }

        elementInFormula = partialElOfSequence.Dequeue();
        firstElOfSequence.Enqueue(elementInFormula + 1);

        while (firstElOfSequence.Count>0)
        {
            Console.Write($"{firstElOfSequence.Dequeue()} ");
        }
    }
}

