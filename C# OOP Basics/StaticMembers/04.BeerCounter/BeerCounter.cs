public class BeerCounter
{
    static int beerInStock;
    static int beersDrankCount;

    static BeerCounter()
    {
        beerInStock = 0;
        beersDrankCount = 0;
    }

    internal static int BuyBeer(int bottlesCount)
    {
        beerInStock += bottlesCount;

        return beerInStock;
    }

    internal static int DrinkBeer(int bottlesCount)
    {
        beersDrankCount += bottlesCount;
        beerInStock -= bottlesCount;

        return beersDrankCount;
    }
}
