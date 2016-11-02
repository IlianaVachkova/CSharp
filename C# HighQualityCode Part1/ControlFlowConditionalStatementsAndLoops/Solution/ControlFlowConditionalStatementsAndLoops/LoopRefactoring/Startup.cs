using System;

public class Startup
{
    private const int ArraySize = 100;

    static void Main()
    {
        bool found = false;
        int expectedValue = 10;
        int[] array = new int[ArraySize];

        for (int i = 0; i < ArraySize; i++)
        {
            if (i % 10 == 0)
            {
                if (array[i] == expectedValue)
                {
                    found = true;
                }
            }
            Console.WriteLine(array[i]);
        }

        if (found)
        {
            Console.WriteLine("Value Found");
        }
    }
}