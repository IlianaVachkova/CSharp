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

                int length = resultAsStr.Length;
                int fillNumber = 0;

                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (direction == '\\')
                        {
                            if (i == j)
                            {
                                fillNumber = resultAsStr[i] - '0';
                                if (j != length - 1)
                                {
                                    Console.Write(fillNumber + " ");
                                }
                                else
                                {
                                    Console.WriteLine(fillNumber);
                                }

                                fillNumber = 0;
                            }
                            else
                            {
                                if (j != length - 1)
                                {
                                    Console.Write(fillNumber + " ");
                                }
                                else
                                {
                                    Console.WriteLine(fillNumber);
                                }
                            }
                        }
                        else if (direction == '/')
                        {
                            if (j == length - 1 - i)
                            {
                                fillNumber = resultAsStr[length - 1 - i] - '0';
                                if (j != length - 1)
                                {
                                    Console.Write(fillNumber + " ");
                                }
                                else
                                {
                                    Console.WriteLine(fillNumber);
                                }

                                fillNumber = 0;
                            }
                            else
                            {
                                if (j != length - 1)
                                {
                                    Console.Write(fillNumber + " ");
                                }
                                else
                                {
                                    Console.WriteLine(fillNumber);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}