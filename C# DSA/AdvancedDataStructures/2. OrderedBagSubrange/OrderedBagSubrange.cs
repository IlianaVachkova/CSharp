using System;
using System.Diagnostics;
using System.Linq;
using Wintellect.PowerCollections;

public class OrderedBagSubrange
{
    public static void Main()
    {
        OrderedBag<Product> products = new OrderedBag<Product>();
        for (int i = 0; i < 500000; i++)
        {
            // Adding is slow
            products.Add(new Product("JustProduct" + i, (decimal)(12.234 * i + 3.234)));
        }

        Stopwatch timer = new Stopwatch();
        timer.Start();

        for (int i = 0; i < 10000; i++)
        {
            var rangeProducts = products.Range(
            new Product(string.Empty, 100m + i), true,
            new Product(string.Empty, 2000m + i * 2), true).Take(20);

            //// Print them if you want to see the result but it's slow
            //foreach (var item in rangeProducts)
            //{
            //    Console.WriteLine(item);
            //}
        }

        timer.Stop();
        Console.WriteLine(timer.Elapsed);
    }
}