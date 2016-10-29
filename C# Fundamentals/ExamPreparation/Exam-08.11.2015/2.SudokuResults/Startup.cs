using System;

namespace _2.SudokuResults
{
    public class Startup
    {
        public static void Main()
        {
            int averageTime = 0;
            int minutes = 0;
            int seconds = 0;
            int countGames = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line=="Quit")
                {
                    break;
                }

                string[] lineAsArr = line.Split(':');
                minutes = int.Parse(lineAsArr[0]);
                seconds = int.Parse(lineAsArr[1]);

                averageTime += minutes * 60 + seconds;
                countGames += 1;
            }

            double averageSeconds=Math.Ceiling((double)averageTime/countGames);

            if (averageSeconds<720)
            {
                Console.WriteLine("Gold Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", countGames, averageSeconds);
            }
            else if (averageSeconds>=720 && averageSeconds<=1440)
            {
                Console.WriteLine("Silver Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", countGames, averageSeconds);
            }
            else if (averageSeconds>1440)
            {
                Console.WriteLine("Bronze Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", countGames, averageSeconds);
            }
        }
    }
}
