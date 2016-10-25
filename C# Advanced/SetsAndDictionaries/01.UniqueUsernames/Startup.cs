/*
    Write a simple program that reads from the console a sequence of usernames and keeps 
    a collection with only the unique ones. Print the collection on the console:

    Input:	            Output:
    6                   Ivan
    Ivan                SemoMastikata
    Ivan                Hubaviq1234
    Ivan
    SemoMastikata
    Ivan
    Hubaviq1234	
*/

using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        HashSet<string> uniqieUSernames = new HashSet<string>();

        for (int i = 0; i < number; i++)
        {
            uniqieUSernames.Add(Console.ReadLine());
        }

        foreach (var item in uniqieUSernames)
        {
            Console.WriteLine(item);
        }
    }
}

