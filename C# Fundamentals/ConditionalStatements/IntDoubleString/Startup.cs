/*
    Write a program that, depending on the first line of the input, reads an int, double or string variable.

        * If the variable is int or double, the program increases it by one.
        * If the variable is a string, the program appends * at the end.
        * Print the result at the console. Use switch statement.
*/

using System;

public class Startup
{
    static void Main()
    {
        string typeOfInput = Console.ReadLine();
        string value = Console.ReadLine();

        if (typeOfInput == "integer")
        {
            int intNum = int.Parse(value);
            Console.WriteLine(intNum + 1);
        }
        else if (typeOfInput == "real")
        {
            double realNum = double.Parse(value);
            Console.WriteLine("{0:0.00}", (realNum + 1));
        }
        else if (typeOfInput == "text")
        {
            Console.WriteLine(value + "*");
        }
    }
}

