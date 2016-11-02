using System;

public static class CompareAddAction
{
    public const int LOOP_END = 100000000;

    public static void Int()
    {
        Console.Write("Value-Int, Operation-Add:\t\t");
        Display.ExecutionTime(() =>
        {
            int result = 0;
            for (int i = 0; i < LOOP_END; i++)
            {
                result++;
            }
        });
    }

    public static void Long()
    {
        Console.Write("Value-Long, Operation-Add:\t\t");
        Display.ExecutionTime(() =>
            {
                long result = 0;
                for (int i = 0; i < LOOP_END; i++)
                {
                    result++;
                }
            });
    }

    public static void Float()
    {
        Console.Write("Value-Float, Operation-Add:\t\t");
        Display.ExecutionTime(() =>
        {
            float result = 0;
            for (int i = 0; i < LOOP_END; i++)
            {
                result++;
            }
        });
    }

    public static void Double()
    {
        Console.Write("Value-Double, Operation-Add:\t\t");
        Display.ExecutionTime(() =>
        {
            double result = 0;
            for (int i = 0; i < LOOP_END; i++)
            {
                result++;
            }
        });
    }

    public static void Decimal()
    {
        Console.Write("Value-Decimal, Operation-Add:\t\t");
        Display.ExecutionTime(() =>
        {
            decimal result = 0;
            for (int i = 0; i < LOOP_END; i++)
            {
                result++;
            }
        });
    }
}