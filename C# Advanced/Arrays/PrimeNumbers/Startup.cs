/*
    Write a program that finds all prime numbers in the range [1 ... N]. 
    Use the Sieve of Eratosthenes algorithm. The program should print the 
    biggest prime number which is <= N.
*/

using System;

public class Startup
{
    public static void Main()
    {

        int count = int.Parse(Console.ReadLine());
        bool[] prime = new bool[count + 1];
        int biggest = 0;
        for (int i = 2; i <= count; i++)
        {
            prime[i] = true;
        }

        for (int number = 2; number <= count; number++)
        {
            if (prime[number])
            {
                if (number > biggest)
                {
                    biggest = number;
                }

                for (int i = 2 * number; i <= count; i += number)
                {
                    prime[i] = false;
                }
            }
        }

        Console.WriteLine(biggest);
    }
}