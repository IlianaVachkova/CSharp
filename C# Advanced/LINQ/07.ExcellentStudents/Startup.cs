/*
    Print all students that have at least one mark Excellent (6). Use LINQ/Stream.
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

            if (marks.Any(m => m == 6))
            {
                Console.WriteLine(name);
            }

            line = Console.ReadLine();
            marks.Clear();
        }
    }
}

