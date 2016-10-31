using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class BunnyFactory
{
    static void Main()
    {
        string cage = Console.ReadLine();
        List<int> cages = new List<int>();
        List<int> newCages = new List<int>();

        while (cage != "END")
        {
            cages.Add(int.Parse(cage));
            cage = Console.ReadLine();
        }

        int index = 0;
        BigInteger sum = 0;
        BigInteger product = 1;
        int nextCages = 0;

        while (true)
        {
            if (index >= cages.Count)
            {
                break;
            }

            for (int i = 0; i < index + 1; i++)
            {
                nextCages += cages[i];
            }

            if (nextCages > cages.Count)
            {
                break;
            }

            for (int i = index + 1; i < index + 1 + nextCages; i++)
            {
                sum += cages[i];
                product *= cages[i];
            }

            cages.RemoveRange(0, nextCages + index + 1);
            string sumStr = sum.ToString();
            string productStr = product.ToString();

            for (int i = 0; i < sumStr.Length; i++)
            {
                if (sumStr[i] != '0' && sumStr[i] != '1')
                {
                    newCages.Add(sumStr[i] - '0');
                }
            }

            for (int i = 0; i < productStr.Length; i++)
            {
                if (productStr[i] != '0' && productStr[i] != '1')
                {
                    newCages.Add(productStr[i] - '0');
                }
            }

            newCages.AddRange(cages);
            cages.Clear();
            cages.AddRange(newCages);

            index++;
            sum = 0;
            product = 1;
            nextCages = 0;
            newCages.Clear();
        }

        Console.WriteLine(String.Join(" ", cages));
    }
}

