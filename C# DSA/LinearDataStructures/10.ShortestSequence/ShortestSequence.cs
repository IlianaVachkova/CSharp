using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortestSequence
{
    public class ShortestSequence
    {
        public static void Main()
        {
            int start = 5;
            int end = 16;
            Queue<int> numbers = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();
            visited.Add(start);
            numbers.Enqueue(start);
            int currentNumber = int.MinValue;

            while (true)
            {
                if (currentNumber == end)
                {
                    break;
                }

                currentNumber = numbers.Dequeue();

                if (!visited.Contains(currentNumber + 1))
                {
                    numbers.Enqueue(currentNumber + 1);
                    visited.Add(currentNumber + 1);
                }

                if (!visited.Contains(currentNumber + 2))
                {
                    numbers.Enqueue(currentNumber + 2);
                    visited.Add(currentNumber + 2);
                }

                if (!visited.Contains(currentNumber * 2))
                {
                    numbers.Enqueue(currentNumber * 2);
                    visited.Add(currentNumber * 2);
                }

                Console.WriteLine(string.Join(" ", visited));
            }
        }
    }
}
