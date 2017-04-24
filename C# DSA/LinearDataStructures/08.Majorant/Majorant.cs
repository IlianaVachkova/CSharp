using System;
using System.Collections.Generic;
using System.Linq;

namespace Majorant
{
    public class Majorant
    {
        public static void Main()
        {
            var arr = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            var majorant = FindMajorant(arr);
            if (majorant == int.MinValue)
            {
                Console.WriteLine("There is no majorant.");
            }
            else
            {
                Console.WriteLine("The majorant is {0}.", majorant);
            }
        }

        public static int FindMajorant(int[] arr)
        {
            var majorant = int.MinValue;
            var dict = new Dictionary<int, int>();
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                var currentElement = arr[i];
                if (dict.ContainsKey(currentElement))
                {
                    dict[currentElement]++;
                    if (dict[currentElement] > length / 2)
                    {
                        majorant = currentElement;
                        break;
                    }
                }
                else
                {
                    dict.Add(currentElement, 1);
                }
            }

            return majorant;
        }
    }
}
