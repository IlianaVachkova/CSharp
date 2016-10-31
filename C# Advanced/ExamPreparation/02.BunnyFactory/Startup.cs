using System;
using System.Text;

public class Startup
{
    public static void Main()
    {
        string cage = Console.ReadLine();
        StringBuilder cages = new StringBuilder();
        StringBuilder newCages = new StringBuilder();

        while (cage != "END")
        {
            cages.Append(cage);
            cage = Console.ReadLine();
        }

        int index = 0;
        long sum = 0;
        long product = 1;
        int nextCages = 0;

        while (true)
        {
            for (int i = 0; i < index + 1; i++)
            {
                nextCages += cages[i] - '0';
            }

            if (nextCages > cages.Length)
            {
                break;
            }

            for (int i = index + 1; i < index + 1 + nextCages; i++)
            {
                sum += cages[i] - '0';
                product *= cages[i] - '0';
            }

            cages.Remove(0, nextCages + index + 1);
            string sumStr = sum.ToString();
            string productStr = product.ToString();

            for (int i = 0; i < sumStr.Length; i++)
            {
                if (sumStr[i] != '0' && sumStr[i] != '1')
                {
                    newCages.Append(sumStr[i]);
                }
            }

            for (int i = 0; i < productStr.Length; i++)
            {
                if (productStr[i] != '0' && productStr[i] != '1')
                {
                    newCages.Append(productStr[i]);
                }
            }

            newCages.Append(cages);
            cages.Clear();
            cages.Append(newCages);

            index++;
            sum = 0;
            product = 1;
            nextCages = 0;
            newCages.Clear();
        }

        for (int i = 0; i < cages.Length; i++)
        {
            Console.Write(cages[i] + " ");
        }
    }
}

