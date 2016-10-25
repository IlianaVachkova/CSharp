using System;
using System.Collections.Generic;

namespace GenericCountMethod
{
    public class Startup
    {
        public static int CountGreaterElements<T>(List<T> elements, T searchedEl) where T : IComparable<T>
        {
            int counter = 0;

            foreach (var element in elements)
            {
                if (element.CompareTo(searchedEl) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static void Main()
        {
            //example with string
            /*
            List<string> elements = new List<string>();
            
            int numOfStr = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfStr; i++)
            {
                elements.Add(Console.ReadLine());
            }
            
            string searchedElement = Console.ReadLine();
            
            Console.WriteLine(CountGreaterElements(elements, searchedElement));
            */

            //example with double
            List<double> elements = new List<double>();

            int numOfStr = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfStr; i++)
            {
                elements.Add(double.Parse(Console.ReadLine()));
            }

            double searchedElement = double.Parse(Console.ReadLine());

            Console.WriteLine(CountGreaterElements(elements, searchedElement));
        }
    }
}
