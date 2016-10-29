using System;
using System.Numerics;

namespace CakeTycoon
{
    public class Startup
    {
        public static void Main()
        {
            BigInteger wantedCakes = BigInteger.Parse(Console.ReadLine());
            double kgNeededForCake = double.Parse(Console.ReadLine());
            long kgAvailable = long.Parse(Console.ReadLine());
            long trufflesAvailable = long.Parse(Console.ReadLine());
            long priceOfTruffle = long.Parse(Console.ReadLine());

            BigInteger realCakes = (BigInteger)Math.Floor((double)kgAvailable / kgNeededForCake);
            BigInteger trufflesCost = 0;
            double cakePiece;
            double kgNeeded;
            double totalFlour;

            if (realCakes >= wantedCakes)
            {
                trufflesCost = trufflesAvailable * priceOfTruffle;
                cakePiece = ((double)trufflesCost / (double)wantedCakes) * 1.25;

                Console.WriteLine("All products available, price of a cake: {0:0.00}", cakePiece);
            }
            else
            {
                totalFlour = (double)wantedCakes * kgNeededForCake;
                kgNeeded = totalFlour - kgAvailable;

                Console.WriteLine("Can make only {0} cakes, need {1:0.00} kg more flour", realCakes, kgNeeded);
            }
        }
    }
}
