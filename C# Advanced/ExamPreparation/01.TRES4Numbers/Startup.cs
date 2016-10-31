using System;
using System.Numerics;

public class Startup
{
    public static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        string result = string.Empty;

        if (number == 0)
        {
            Console.WriteLine("LON+");
            return;
        }

        while (number != 0)
        {
            int reminder = (int)(number % 9);

            switch (reminder)
            {
                case 0: result = "LON+" + result; break;
                case 1: result = "VK-" + result; break;
                case 2: result = "*ACAD" + result; break;
                case 3: result = "^MIM" + result; break;
                case 4: result = "ERIK|" + result; break;
                case 5: result = "SEY&" + result; break;
                case 6: result = "EMY>>" + result; break;
                case 7: result = "/TEL" + result; break;
                case 8: result = "<<DON" + result; break;
            }

            number /= 9;
        }

        Console.WriteLine(result);
    }
}
