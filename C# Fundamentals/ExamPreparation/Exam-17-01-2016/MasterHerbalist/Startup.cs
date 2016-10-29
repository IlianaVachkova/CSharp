using System;
using System.Numerics;

namespace MasterHerbalist
{
    public class Startup
    {
        public static void Main()
        {
            int dailyExpenses = int.Parse(Console.ReadLine());

            string[] commandAsArr;
            int hours, price, daysCount = 0;
            string path;
            long totalMoney = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Season Over")
                {
                    break;
                }

                commandAsArr = command.Split(' ');
                hours = int.Parse(commandAsArr[0]);
                path = commandAsArr[1];
                price = int.Parse(commandAsArr[2]);

                int j = 0, countH = 0;
                for (int i = 0; i < hours; i++)
                {

                    if (j == path.Length)
                    {
                        j = 0;
                    }

                    if (path[j] == 'H')
                    {
                        countH += 1;
                    }

                    j += 1;
                }

                daysCount += 1;
                totalMoney += countH * price;

                command = string.Empty;
                countH = 0;
            }

            double averageEarning = (double)totalMoney / (double)daysCount;

            if (averageEarning >= dailyExpenses)
            {
                double difference = averageEarning - (double)dailyExpenses;
                Console.WriteLine("Times are good. Extra money per day: {0:0.00}.", difference);
            }
            else
            {
                BigInteger difference = (dailyExpenses * daysCount) - totalMoney;
                Console.WriteLine("We are in the red. Money needed: {0}.", difference);
            }
        }
    }
}
