using System;

public static class CompareSinAction
{
    public const int LOOP_END = 10000000;

    public static void Float()
    {
        Console.Write("Value-Float, Operation-Sin:\t\t");
        Display.ExecutionTime(() =>
        {
            float result = float.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result = (float)Math.Sin(result);
            }
        });
    }

    public static void Double()
    {
        Console.Write("Value-Double, Operation-Sin:\t\t");
        Display.ExecutionTime(() =>
        {
            double result = double.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result = Math.Sin(result);
            }
        });
    }

    public static void Decimal()
    {
        Console.Write("Value-Decimal, Operation-Sin:\t\t");
        Display.ExecutionTime(() =>
        {
            decimal result = 100;
            for (int i = 0; i < LOOP_END; i++)
            {
                result = (decimal)Math.Sin((double)result);
            }
        });
    }
}