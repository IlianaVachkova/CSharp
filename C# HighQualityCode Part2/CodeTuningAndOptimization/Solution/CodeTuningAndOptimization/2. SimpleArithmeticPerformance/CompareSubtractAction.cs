using System;

public static class CompareSubtractAction
{
    public const int LOOP_END = 100000000;

    public static void Int()
    {
        Console.Write("Value-Int, Operation-Subtract:\t\t");
        Display.ExecutionTime(() =>
        {
            int result = int.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result++;
            }
        });
    }

    public static void Long()
    {
        Console.Write("Value-Long, Operation-Subtract:\t\t");
        Display.ExecutionTime(() =>
        {
            long result = long.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result++;
            }
        });
    }

    public static void Float()
    {
        Console.Write("Value-Float, Operation-Subtract:\t");
        Display.ExecutionTime(() =>
        {
            float result = float.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result++;
            }
        });
    }

    public static void Double()
    {
        Console.Write("Value-Double, Operation-Subtract:\t");
        Display.ExecutionTime(() =>
        {
            double result = double.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result++;
            }
        });
    }

    public static void Decimal()
    {
        Console.Write("Value-Decimal, Operation-Subtract:\t");
        Display.ExecutionTime(() =>
        {
            decimal result = decimal.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result--;
            }
        });
    }
}