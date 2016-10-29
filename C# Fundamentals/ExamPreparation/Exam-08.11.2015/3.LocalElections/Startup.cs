using System;

namespace _3.LocalElections
{
    public class Startup
    {
        public static void Main()
        {
            int totalCandidates = int.Parse(Console.ReadLine());
            int electorVote = int.Parse(Console.ReadLine());
            char votingSymbol = char.Parse(Console.ReadLine());


            for (int j = 1; j <= totalCandidates; j++)
            {
                string number = string.Empty;

                if (j < 10)
                {
                    number += '0';
                    number += j;
                }
                else
                {
                    number = Convert.ToString(j);
                }

                Console.WriteLine(new string('.', 13));
                Console.WriteLine(new string('.', 3) + '+' + new string('-', 5) + '+' + new string('.', 3));


                if (j == electorVote && (votingSymbol == 'v' || votingSymbol == 'V'))
                {
                    Console.WriteLine(new string('.', 3) + '|' + '\\' + new string('.', 3) + '/' + '|' + new string('.', 3));
                    Console.WriteLine(number + '.' + '|' + '.' + '\\' + '.' + '/' + '.' + '|' + new string('.', 3));
                    Console.WriteLine(new string('.', 3) + '|' + new string('.', 2) + 'V' + new string('.', 2) + '|'
                        + new string('.', 3));
                }
                else if (j == electorVote && (votingSymbol == 'x' || votingSymbol == 'X'))
                {
                    Console.WriteLine(new string('.', 3) + '|' + '.' + '\\' + '.' + '/' + '.' + '|' + new string('.', 3));
                    Console.WriteLine(number + '.' + '|' + new string('.', 2) + 'X' + new string('.', 2) + '|' 
                        + new string('.', 3));
                    Console.WriteLine(new string('.', 3) + '|' + '.' + '/' + '.' + '\\' + '.' + '|' + new string('.', 3));
                }
                else
                {
                    Console.WriteLine(new string('.', 3) + '|' + new string('.', 5) + '|' + new string('.', 3));
                    Console.WriteLine(number + '.' + '|' + new string('.', 5) + '|' + new string('.', 3));
                    Console.WriteLine(new string('.', 3) + '|' + new string('.', 5) + '|' + new string('.', 3));
                }

                Console.WriteLine(new string('.', 3) + '+' + new string('-', 5) + '+' + new string('.', 3));
            }

            Console.WriteLine(new string('.', 13));
        }
    }
}
