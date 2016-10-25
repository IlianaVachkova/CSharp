/*
    Write a similar program to the previous one to extract the students 
    with at least 2 marks under or equal to "3". Use LINQ/Stream.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        string line = Console.ReadLine();
        List<int> marks = new List<int>();

        while (line != "END")
        {
            string[] lineAsArr = line.Split(' ');
            string name = lineAsArr[0] + " " + lineAsArr[1];

            for (int i = 2; i < lineAsArr.Length; i++)
            {
                marks.Add(int.Parse(lineAsArr[i]));
            }

            if (marks.Count(m => m <= 3) >= 2)
            {
                Console.WriteLine(name);
            }

            line = Console.ReadLine();
            marks.Clear();
        }
    }
}
