using System;

public static class CompareMultiplyAction
{
    public const int LOOP_END = 95;

    public static void Int()
    {
        Console.Write("Value-Int, Operation-Multiply:\t\t");
        Display.ExecutionTime(() =>
        {
            int result = 1;
            for (int i = 0; i < LOOP_END; i++)
            {
                result *= 2;
            }
        });
    }

    public static void Long()
    {
        Console.Write("Value-Long, Operation-Multiply:\t\t");
        Display.ExecutionTime(() =>
        {
            long result = 1;
            for (int i = 0; i < LOOP_END; i++)
            {
                result *= 2;
            }
        });
    }

    public static void Float()
    {
        Console.Write("Value-Float, Operation-Multiply:\t");
        Display.ExecutionTime(() =>
        {
            float result = 1;
            for (int i = 0; i < LOOP_END; i++)
            {
                result *= 2;
            }
        });
    }

    public static void Double()
    {
        Console.Write("Value-Double, Operation-Multiply:\t");
        Display.ExecutionTime(() =>
        {
            double result = 1;
            for (int i = 0; i < LOOP_END; i++)
            {
                result *= 2;
            }
        });
    }

    public static void Decimal()
    {
        Console.Write("Value-Decimal, Operation-Multiply:\t");
        Display.ExecutionTime(() =>
        {
            decimal result = 1;
            for (int i = 0; i < LOOP_END; i++)
            {
                result *= 2;
            }
        });
    }
}