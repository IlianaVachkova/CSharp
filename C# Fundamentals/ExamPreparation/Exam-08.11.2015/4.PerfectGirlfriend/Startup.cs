using System;
using System.Linq;

namespace PerfectGirlfriend
{
    public class Startup
    {
        public static void Main()
        {
            int perfect = 0;

            while (true)
            {
                string command = Console.ReadLine();
                int sum = 0;

                if (command == "Enough dates!")
                {
                    break;
                }

                string[] commandParts = command.Split('\\').ToArray();
                string day = commandParts[0];
                string number = commandParts[1];
                string bra = commandParts[2];
                string name = commandParts[3];

                int digitForDay = 0;
                switch (day)
                {
                    case "Monday": digitForDay = 1; break;
                    case "Tuesday": digitForDay = 2; break;
                    case "Wednesday": digitForDay = 3; break;
                    case "Thursday": digitForDay = 4; break;
                    case "Friday": digitForDay = 5; break;
                    case "Saturday": digitForDay = 6; break;
                    case "Sunday": digitForDay = 7; break;
                }

                int sumFromNumber = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    sumFromNumber += number[i] - '0';
                }

                int braNumber = int.Parse(bra.Substring(0, bra.Length - 1));
                int braSum = braNumber * (bra[bra.Length - 1] - 'A' + 65);

                int firstNameLetter = name[0] - 'A' + 65;
                int nameSum = firstNameLetter * name.Length;

                sum = digitForDay + sumFromNumber + braSum - nameSum;

                if (sum < 6000)
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", name);
                }
                else
                {
                    perfect += 1;
                    Console.WriteLine("{0} is perfect for you.", name);
                }

                sum = 0;
            }

            Console.WriteLine(perfect);
        }
    }
}
