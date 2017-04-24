using System;

public class MinimumEditDistance
{
    public const decimal CostReplace = 1.0m;
    public const decimal CostDelete = 0.9m;
    public const decimal CostInsert = 0.8m;

    public static void Main()
    {
        Console.WriteLine(CalcMinCost("developer", "enveloped"));
        Console.WriteLine(CalcMinCost("dev", "enveloped"));
    }

    public static decimal CalcMinCost(string first, string second)
    {
        decimal[,] distanceMatrix = new decimal[first.Length + 1, second.Length + 1];

        for (int row = 0; row < distanceMatrix.GetLength(0); row++)
        {
            distanceMatrix[row, 0] = row * CostDelete;
        }

        for (int col = 0; col < distanceMatrix.GetLength(1); col++)
        {
            distanceMatrix[0, col] = col * CostInsert;
        }

        for (int row = 1; row < distanceMatrix.GetLength(0); row++)
        {
            for (int col = 1; col < distanceMatrix.GetLength(1); col++)
            {
                decimal cost = (second[col - 1] == first[row - 1]) ? 0 : CostReplace;

                decimal delete = distanceMatrix[row - 1, col] + CostDelete;
                decimal replace = distanceMatrix[row - 1, col - 1] + cost;
                decimal insert = distanceMatrix[row, col - 1] + CostInsert;

                distanceMatrix[row, col] = Math.Min(Math.Min(delete, insert),replace);
            }
        }

        return distanceMatrix[first.Length, second.Length];
    }
}