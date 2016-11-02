using System;

public static class CompareLogAction
{
    public const int LOOP_END = 10000000;
    public const double LOG_ARGUMENT = 1000;

    public static void Float()
    {
        Console.Write("Value-Float, Operation-Sqrt:\t\t");
        Display.ExecutionTime(() =>
        {
            float result = 0;
            for (int i = 0; i < LOOP_END; i++)
            {
                result = (float)Math.Log(LOG_ARGUMENT);
            }
        });
    }

    public static void Double()
    {
        Console.Write("Value-Double, Operation-Sqrt:\t\t");
        Display.ExecutionTime(() =>
        {
            double result = 0;
            for (int i = 0; i < LOOP_END; i++)
            {
                result = Math.Log(LOG_ARGUMENT);
            }
        });
    }

    public static void Decimal()
    {
        Console.Write("Value-Decimal, Operation-Sqrt:\t\t");
        Display.ExecutionTime(() =>
        {
            decimal result = 0;
            for (int i = 0; i < LOOP_END; i++)
            {
                result = (decimal)Math.Log(LOG_ARGUMENT);
            }
        });
    }
}