/*
    Write a program that reads your birthday(in the format MM.DD.YYYY) from the console and prints 
    on the console how old you are you now and how old will you be after 10 years.
*/

using System;

public class Startup
{
    static void Main()
    {
        DateTime birthday = DateTime.Parse(Console.ReadLine());

        DateTime today = DateTime.Now;
        int age = today.Year - birthday.Year;

        if (today < birthday.AddYears(age))
        {
            age -= 1;
        }

        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}
