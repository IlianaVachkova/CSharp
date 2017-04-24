using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Rabbits
{
    public class Rabbits
    {
        public static void Main()
        {
            int askedRabbits = int.Parse(Console.ReadLine());
            BigInteger allRabbits = 0;
            int[] rabbitsArr = new int[askedRabbits];
            List<int> rabbitsList = new List<int>();

            for (int i = 0; i < askedRabbits; i++)
            {
                rabbitsArr[i] = int.Parse(Console.ReadLine());
            }

            rabbitsList.Add(rabbitsArr[0]);
            BigInteger rabbitsListCount = rabbitsArr[0];

            int count = 0;
            for (int i = 1; i < rabbitsArr.Length; i++)
            {
                if (rabbitsArr[i] != rabbitsArr[i - 1])
                {
                    rabbitsList.Add(rabbitsArr[i]);
                    rabbitsListCount += rabbitsArr[i];
                    count = 0;
                }
                else
                {
                    count += 1;
                    if (count > rabbitsArr[i])
                    {
                        rabbitsList.Add(rabbitsArr[i]);
                        rabbitsListCount += rabbitsArr[i];
                        count = 0;
                    }
                }
            }

            int differentRabbits = rabbitsList.Count();
            allRabbits = rabbitsListCount + differentRabbits;
            Console.WriteLine(allRabbits);
        }
    }
}