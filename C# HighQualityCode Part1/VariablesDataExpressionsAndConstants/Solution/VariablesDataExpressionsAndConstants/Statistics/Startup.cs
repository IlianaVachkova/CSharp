using System;

namespace Statistics
{
    public class Startup
    {
        static void Main()
        {
            Statistic statistics = new Statistic();
            var elements = new double[] { 1, 2, 3, 2, 5 };
            Console.WriteLine(statistics.PrintStatistics(elements));
        }
    }
}