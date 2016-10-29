using System;

namespace FirefightingOrganization
{
    public class Startup
    {
        public static void Main()
        {
            int firefighters = int.Parse(Console.ReadLine());
            int totalKids = 0;
            int totalAdults = 0;
            int totalSeniors = 0;

            while (true)
            {
                string line = Console.ReadLine();
                int kidsCount = 0;
                int adultsCount = 0;
                int seniorCount = 0;
                int restForAdults = 0;
                int restForSeniors = 0;

                if (line == "rain")
                {
                    break;
                }

                for (int i = 0; i < line.Length; i++)
                {
                    switch (line[i])
                    {
                        case 'K': kidsCount += 1; break;
                        case 'A': adultsCount += 1; break;
                        case 'S': seniorCount += 1; break;
                    }
                }

                if (kidsCount >= firefighters)
                {
                    totalKids += firefighters;
                }
                else if (kidsCount < firefighters)
                {
                    restForAdults = firefighters - kidsCount;
                    totalKids += kidsCount;
                }

                if (adultsCount >= restForAdults)
                {
                    totalAdults += restForAdults;
                }
                else if (adultsCount < restForAdults)
                {
                    restForSeniors = restForAdults - adultsCount;
                    totalAdults += adultsCount;
                }

                if (seniorCount >= restForSeniors)
                {
                    totalSeniors += restForSeniors;
                }
                else
                {
                    totalSeniors += seniorCount;
                }

            }

            Console.WriteLine("Kids: {0}", totalKids);
            Console.WriteLine("Adults: {0}", totalAdults);
            Console.WriteLine("Seniors: {0}", totalSeniors);
        }
    }
}
