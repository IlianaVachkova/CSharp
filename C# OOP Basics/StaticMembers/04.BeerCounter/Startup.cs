using System;

public class Startup
{
    public static void Main()
    {
        string line = Console.ReadLine();
        int beersInStockS = 0;
        int beersDrankCountS = 0;
        while (line != "End")
        {
            string[] lineAsArr = line.Split();
            beersInStockS += int.Parse(lineAsArr[0]);
            beersDrankCountS += int.Parse(lineAsArr[1]);

            line = Console.ReadLine();
        }

        int drinkedBeers = BeerCounter.DrinkBeer(beersDrankCountS);
        int boughtBeers = BeerCounter.BuyBeer(beersInStockS);

        Console.WriteLine("{0} {1}", boughtBeers, drinkedBeers);
    }
}
