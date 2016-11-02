using System;

public static class CompareDivideAction
{
    public const int LOOP_END = 10000000;

    public static void Int()
    {
        Console.Write("Value-Int, Operation-Divide:\t\t");
        Display.ExecutionTime(() =>
        {
            int result = int.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result /= 2;
            }
        });
    }

    public static void Long()
    {
        Console.Write("Value-Long, Operation-Divide:\t\t");
        Display.ExecutionTime(() =>
        {
            long result = long.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result /= 2;
            }
        });
    }

    public static void Float()
    {
        Console.Write("Value-Float, Operation-Divide:\t\t");
        Display.ExecutionTime(() =>
        {
            float result = float.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result /= 2;
            }
        });
    }

    public static void Double()
    {
        Console.Write("Value-Double, Operation-Divide:\t\t");
        Display.ExecutionTime(() =>
        {
            double result = double.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result /= 2;
            }
        });
    }

    public static void Decimal()
    {
        Console.Write("Value-Decimal, Operation-Divide:\t");
        Display.ExecutionTime(() =>
        {
            decimal result = decimal.MaxValue;
            for (int i = 0; i < LOOP_END; i++)
            {
                result /= 2;
            }
        });
    }
}