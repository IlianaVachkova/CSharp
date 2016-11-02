using System;

class SimpleArithmeticPerf
{
    static void Main()
    {
        CompareAddAction.Int();
        CompareAddAction.Long();
        CompareAddAction.Double();
        CompareAddAction.Float();
        CompareAddAction.Decimal();

        Console.WriteLine("-----------------------------");

        CompareSubtractAction.Int();
        CompareSubtractAction.Long();
        CompareSubtractAction.Double();
        CompareSubtractAction.Float();
        CompareSubtractAction.Decimal();

        Console.WriteLine("-----------------------------");

        CompareDivideAction.Int();
        CompareDivideAction.Long();
        CompareDivideAction.Double();
        CompareDivideAction.Float();
        CompareDivideAction.Decimal();

        Console.WriteLine("-----------------------------");

        CompareMultiplyAction.Int();
        CompareMultiplyAction.Long();
        CompareMultiplyAction.Double();
        CompareMultiplyAction.Float();
        CompareMultiplyAction.Decimal();

        Console.WriteLine("-----------------------------");

        CompareIncrementAction.Int();
        CompareIncrementAction.Long();
        CompareIncrementAction.Double();
        CompareIncrementAction.Float();
        CompareIncrementAction.Decimal();
    }
}
