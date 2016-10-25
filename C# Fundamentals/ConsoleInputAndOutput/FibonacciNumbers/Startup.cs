/*
    Write a program that reads a number N and prints on the console the first N members of 
    the Fibonacci sequence (at a single line, separated by comma and space - ", ") : 
    0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
*/

using System;

public class Startup
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long member1 = 0;
        long member2 = 1;
        long memberN;

        if (n == 1)
        {
            Console.Write(member1);
        }
        else if (n == 2)
        {
            Console.Write("{0}, {1} ", member1, member2);
        }
        else
        {
            Console.Write("{0}, {1}, ", member1, member2);

            for (int i = 3; i <= n; i++)
            {
                memberN = member1 + member2;
                if (i!=n)
                {
                    Console.Write(memberN + ", ");
                }
                else
                {
                    Console.Write(memberN);
                }

                member1 = member2;
                member2 = memberN;
            }
        }
    }
}

