using System;
using System.Collections.Generic;

namespace _4.ArrayMatcher
{
    public class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] inputAsArr = input.Split('\\');
            string firstArr = inputAsArr[0];
            string secondArr = inputAsArr[1];
            string command = inputAsArr[2];

            List<char> result = new List<char>();

            switch (command)
            {
                case "join":
                    for (int i = 0; i < firstArr.Length; i++)
                    {
                        for (int j = 0; j < secondArr.Length; j++)
                        {
                            if (firstArr[i] == secondArr[j])
                            {
                                result.Add(firstArr[i]);
                            }
                        }
                    }
                    break;
                case "left exclude":
                    for (int i = 0; i < secondArr.Length; i++)
                    {
                        bool flagLeft = true;

                        for (int j = 0; j < firstArr.Length; j++)
                        {
                            if (secondArr[i] == firstArr[j])
                            {
                                flagLeft = false;
                            }
                        }
                        if (flagLeft)
                        {
                            result.Add(secondArr[i]);
                        }
                    }
                    break;
                case "right exclude":
                    for (int i = 0; i < firstArr.Length; i++)
                    {
                        bool flagRight = true;

                        for (int j = 0; j < secondArr.Length; j++)
                        {
                            if (firstArr[i] == secondArr[j])
                            {
                                flagRight = false;
                            }
                        }
                        if (flagRight)
                        {
                            result.Add(firstArr[i]);
                        }
                    }
                    break;
            }

            result.Sort();

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i]);
            }

            Console.WriteLine();
        }
    }
}
