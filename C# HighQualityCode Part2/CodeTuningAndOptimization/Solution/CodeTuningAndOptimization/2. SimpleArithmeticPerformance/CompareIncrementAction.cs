using System;

public static class CompareIncrementAction
{
    public const int LOOP_END = 6;

    public static void Int()
    {
        Console.Write("Value-Int, Operation-Increment:\t\t");
        Display.ExecutionTime(() =>
        {
            int result = 2;
            for (int i = 0; i < LOOP_END; i++)
            {
                result *= result;
            }
        });
    }

    public static void Long()
    {
        Console.Write("Value-Long, Operation-Increment:\t");
        Display.ExecutionTime(() =>
        {
            long result = 2;
            for (int i = 0; i < LOOP_END; i++)
            {
                result *= result;
            }
        });
    }

    public static void Float()
    {
        Console.Write("Value-Float, Operation-Increment:\t");
        Display.ExecutionTime(() =>
        {
            float result = 2;
            for (int i = 0; i < LOOP_END; i++)
            {
                result *= result;
            }
        });
    }

    public static void Double()
    {
        Console.Write("Value-Double, Operation-Increment:\t");
        Display.ExecutionTime(() =>
        {
            double result = 2;
            for (int i = 0; i < LOOP_END; i++)
            {
                result *= result;
            }
        });
    }

    public static void Decimal()
    {
        Console.Write("Value-Decimal, Operation-Increment:\t");
        Display.ExecutionTime(() =>
        {
            decimal result = 2;
            for (int i = 0; i < LOOP_END; i++)
            {
                result *= result;
            }
        });
    }
}