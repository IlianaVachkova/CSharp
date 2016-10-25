using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapIndexesMethod
{
    public class Startup
    {
        static List<T> SwapIndexes<T>(List<T> input, int firstIndex, int secondIndex)
        {
            int maxIndex = Math.Max(firstIndex, secondIndex);
            if (maxIndex > input.Count - 1)
            {
                return input;
            }
            else
            {
                T tempValue = input[firstIndex];
                input[firstIndex] = input[secondIndex];
                input[secondIndex] = tempValue;

                return input;
            }
        }

        public static void Main()
        {
            //example with string
            /*
            List<string> input = new List<string>();
            
            int numOfStrings = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfStrings; i++)
            {
                input.Add(Console.ReadLine());
            }
            
            int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];
            
            SwapIndexes(input, firstIndex, secondIndex);
            
            foreach (var item in input)
            {
                Console.WriteLine("{0}: {1}", item.GetType().FullName, item);
            }
            */

            //example with int
            List<int> input = new List<int>();

            int numOfStrings = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfStrings; i++)
            {
                input.Add(int.Parse(Console.ReadLine()));
            }

            int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            SwapIndexes(input, firstIndex, secondIndex);

            foreach (var item in input)
            {
                Console.WriteLine("{0}: {1}", item.GetType().FullName, item);
            }
        }
    }
}
