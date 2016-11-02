using System;

class AdvancedMathArithmetics
{
    static void Main()
    {
        CompareSqrtAction.Float();
        CompareSqrtAction.Double();
        CompareSqrtAction.Decimal();

        Console.WriteLine("-----------------------------");

        CompareSinAction.Float();
        CompareSinAction.Double();
        CompareSinAction.Decimal();

        Console.WriteLine("-----------------------------");

        CompareLogAction.Float();
        CompareLogAction.Double();
        CompareLogAction.Decimal();
    }
}