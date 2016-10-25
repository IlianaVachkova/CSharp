/*
    Extract and print the Marks of the students that enrolled in 2014 or 2015 
    (the students from 2014 have 14 as their 5-th and 6-th digit in the 
    FacultyNumber, those from 2015 have 15).
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        string line = Console.ReadLine();
        List<int> marks = new List<int>();

        while (line != "END")
        {
            string[] lineAsArr = line.Split(' ');
            string facNum = lineAsArr[0];

            for (int i = 1; i < lineAsArr.Length; i++)
            {
                marks.Add(int.Parse(lineAsArr[i]));
            }

            if (facNum.EndsWith("14") || facNum.EndsWith("15"))
            {
                Console.WriteLine(String.Join(" ", marks));
            }

            line = Console.ReadLine();
            marks.Clear();
        }
    }
}

