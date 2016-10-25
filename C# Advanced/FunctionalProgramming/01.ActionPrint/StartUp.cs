/*
    Write a program that reads a collection of strings from the console and then prints 
    them onto the console. Each name should be printed on a new line. Use Action<T>.
*/

using System;

public class Startup
{
    public static void Main()
    {
        string[] names = Console.ReadLine().Split(' ');

        foreach (var name in names)
        {
            Action<string> myAction =Print;
            myAction(name);
        }
    }

    public static void Print(string name)
    {
        Console.WriteLine(name);
    }
}

