/*
    Description:
    Write a program to convert binary numbers to hexadecimal numbers.
    
    Input:
    On the only line you will receive a decimal number - N
        There will not be leading zeros
    
    Output:
    Print the its binary representation on a single line
        There should not be leading zeros
        Use uppercase letters
*/

using System;

public class Startup
{
    public static void Main()
    {
        string binNumber = Console.ReadLine();
        int step = 0;
        long decNumber = 0;
        string result = string.Empty;

        for (int i = binNumber.Length - 1; i >= 0; i--)
        {
            decNumber += (binNumber[i] - '0') * (long)Math.Pow(2, step);
            step++;
        }

        while (decNumber != 0)
        {
            byte hexadecReminder = (byte)(decNumber % 16);
            if (hexadecReminder >= 10 && hexadecReminder <= 15)
            {
                string hexadecRemLetter =String.Empty;
                switch (hexadecReminder)
                {
                    case 10: hexadecRemLetter = "A"; break;
                    case 11: hexadecRemLetter = "B"; break;
                    case 12: hexadecRemLetter = "C"; break;
                    case 13: hexadecRemLetter = "D"; break;
                    case 14: hexadecRemLetter = "E"; break;
                    case 15: hexadecRemLetter = "F"; break;
                }
                result = hexadecRemLetter + result;
            }
            else
            {
                result = hexadecReminder + result;
            }

            decNumber /= 16;
        }

        Console.WriteLine(result);
    }
}

