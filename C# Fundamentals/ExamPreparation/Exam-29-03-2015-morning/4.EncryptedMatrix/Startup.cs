using System;

namespace EncryptedMatrix
{
    public class Startup
    {
        public static void Main()
        {
            string message = Console.ReadLine();
            char direction = char.Parse(Console.ReadLine());
            int[] arr = new int[message.Length];
            int charAsNumber;
            string resultAsStr = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                charAsNumber = (int)message[i];
                arr[i] = charAsNumber % 10;
            }

            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0 || arr[i] == 0)
                    {
                        resultAsStr += arr[i] * arr[i];
                    }
                    else if (arr[i] % 2 == 1)
                    {
                        if (i == 0)
                        {
                            resultAsStr += arr[i] + arr[i + 1];
                        }
                        else if (i == arr.Length - 1)
                        {
                            resultAsStr += arr[i] + arr[i - 1];
                        }
                        else
                        {
                            resultAsStr += arr[i - 1] + arr[i] + arr[i + 1];
                        }
                    }
                }

                int demention = resultAsStr.Length;
                int[,] matrix = new int[demention, demention];

                for (int i = 0; i < demention; i++)
                {
                    for (int j = 0; j < demention; j++)
                    {
                        if (direction == '\\')
                        {
                            if (i == j)
                            {
                                matrix[i, j] = resultAsStr[i] - '0';

                                if (j != demention - 1)
                                {
                                    Console.Write(matrix[i, j] + " ");
                                }
                                else
                                {
                                    Console.WriteLine(matrix[i, j]);
                                }
                            }
                            else
                            {
                                if (j != demention - 1)
                                {
                                    Console.Write(matrix[i, j] + " ");
                                }
                                else
                                {
                                    Console.WriteLine(matrix[i, j]);
                                }
                            }
                        }
                        else if (direction == '/')
                        {
                            if (j == demention - 1 - i)
                            {
                                matrix[i, j] = resultAsStr[demention - 1 - i] - '0';
                                if (j != demention - 1)
                                {
                                    Console.Write(matrix[i, j] + " ");
                                }
                                else
                                {
                                    Console.WriteLine(matrix[i, j]);
                                }
                            }
                            else
                            {
                                if (j != demention - 1)
                                {
                                    Console.Write(matrix[i, j] + " ");
                                }
                                else
                                {
                                    Console.WriteLine(matrix[i, j]);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}