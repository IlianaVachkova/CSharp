using System;
using System.Numerics;

namespace BeerStock
{
    public class Startup
    {
        public static void Main()
        {
            BigInteger recievedBeers = BigInteger.Parse(Console.ReadLine());
            string type;
            BigInteger amount, moreBeers;
            string[] commandAsArr;
            BigInteger realBeers = 0;
            BigInteger realBeersWithoutBroken = 0;
            BigInteger beersLeft = 0;
            BigInteger cases, sixpacks, beers;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Exam Over")
                {
                    break;
                }

                commandAsArr = command.Split(' ');
                amount = int.Parse(commandAsArr[0]);
                type = commandAsArr[1];

                switch (type)
                {
                    case "beers": realBeers += amount; break;
                    case "sixpacks": realBeers += amount * 6; break;
                    case "cases": realBeers += amount * 24; break;
                }

                command = string.Empty;
            }

            realBeersWithoutBroken = realBeers - (realBeers / 100);
            if (realBeersWithoutBroken >= recievedBeers)
            {
                beersLeft = realBeersWithoutBroken - recievedBeers;
                cases = beersLeft / 24;
                sixpacks = (beersLeft % 24) / 6;
                beers = (beersLeft % 24) % 6;

                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beers);
            }
            else
            {
                moreBeers = recievedBeers - realBeersWithoutBroken;
                cases = moreBeers / 24;
                sixpacks = (moreBeers % 24) / 6;
                beers = (moreBeers % 24) % 6;

                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beers);
            }
        }
    }
}
