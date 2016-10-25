/*
    Write a program that reads a collection of names as strings from the console then 
    appends “Sir” in front of every name and prints it back onto the console. Use Action<T>.
*/

using System;

public class Startup
{
    public static void Main()
    {
        string[] names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var name in names)
        {
            Action<string> myAction = Print;
            myAction(name);
        }
    }

    public static void Print(string name)
    {
        Console.WriteLine("Sir " + name);
    }
}

