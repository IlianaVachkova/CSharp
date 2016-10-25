/*
    You have an empty sequence, and you will be given N queries. Each query is one of these three types:
        1 x - Push the element x into the stack.
        2    - Delete the element present at the top of the stack.
        3    - Print the maximum element in the stack.

    Input Format: The first line of input contains an integer, N. The next N lines each contain an above 
    mentioned query. (It is guaranteed that each query is valid.)

    Output Format: For each type 3 query, print the maximum element in the stack on a new line.

    Constraints:
    1 ≤ N ≤ 105
    1 ≤ x ≤ 109
    1 ≤ type ≤ 3

    Input:	Output:
    9       26
    1 97    91
    2
    1 20
    2
    1 26
    1 20
    3
    1 91
    3	
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int queries = int.Parse(Console.ReadLine());
        Stack<int> elements = new Stack<int>();
        string currentQuery = string.Empty;
        int maxElement = int.MinValue;

        for (int i = 0; i < queries; i++)
        {
            currentQuery = Console.ReadLine().Trim();

            if (currentQuery.Length == 1)
            {
                if (currentQuery == "2")
                {
                    if (elements.Peek() == maxElement)
                    {
                        maxElement = int.MinValue;
                    }

                    elements.Pop();
                }
                else if (currentQuery == "3")
                {
                    if (maxElement == int.MinValue)
                    {
                        int[] elementsAsArr = elements.ToArray();
                        Console.WriteLine(elementsAsArr.Max());
                    }
                    else
                    {
                        Console.WriteLine(maxElement);
                    }
                }
            }
            else if (currentQuery.Length > 1)
            {
                int[] elementsInQuery = currentQuery.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x)).ToArray();

                if (elementsInQuery[1] > maxElement)
                {
                    maxElement = elementsInQuery[1];
                }

                elements.Push(elementsInQuery[1]);
            }
        }
    }
}


