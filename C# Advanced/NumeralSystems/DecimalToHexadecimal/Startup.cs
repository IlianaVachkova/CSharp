/*
    Description:
    Write a program that converts a decimal number N to its hexadecimal representation.
    
    Input:
    On the only line you will receive a decimal number - N
    There will not be leading zeros
    
    Output:    
    Print the hexadecimal representation of N on a single line
        There should not be leading zeros
        Use uppercase letters
*/

using System;

public class Startup
{
    public static void Main()
    {
        long decNumber = long.Parse(Console.ReadLine());
        string result = String.Empty;

        while (decNumber != 0)
        {
            byte hexadecReminder = (byte)(decNumber % 16);

            if (hexadecReminder >= 10 && hexadecReminder <= 15)
            {
                string hexadecReminderLetter = String.Empty;
                switch (hexadecReminder)
                {
                    case 10: hexadecReminderLetter = "A"; break;
                    case 11: hexadecReminderLetter = "B"; break;
                    case 12: hexadecReminderLetter = "C"; break;
                    case 13: hexadecReminderLetter = "D"; break;
                    case 14: hexadecReminderLetter = "E"; break;
                    case 15: hexadecReminderLetter = "F"; break;
                }

                result = hexadecReminderLetter + result;
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

