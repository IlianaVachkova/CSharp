using System;

public static class CompareSqrtAction
{
    public const int LOOP_END = 10000000;

    public static void Float()
    {
        Console.Write("Value-Float, Operation-Sqrt:\t\t");
        Display.ExecutionTime(() =>
        {
            float result = float.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result = (float)Math.Sqrt(result);
            }
        });
    }

    public static void Double()
    {
        Console.Write("Value-Double, Operation-Sqrt:\t\t");
        Display.ExecutionTime(() =>
        {
            double result = double.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result = Math.Sqrt(result);
            }
        });
    }

    public static void Decimal()
    {
        Console.Write("Value-Decimal, Operation-Sqrt:\t\t");
        Display.ExecutionTime(() =>
        {
            decimal result = decimal.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result = (decimal)Math.Sqrt((double)result);
            }
        });
    }
}