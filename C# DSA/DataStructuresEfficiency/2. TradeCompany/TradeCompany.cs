using System;
using Wintellect.PowerCollections;

public class TradeCompany
{
    static void Main()
    {
        var articles = new OrderedMultiDictionary<decimal, Article>(true);
        for (int i = 0; i < 100000; i++)
        {
            var phone = new Article("Samsung", "Galaxy S" + i, 203.23M + i/2, "10000238092" + i);
            articles.Add(phone.Price, phone);
        }

        var fromPrice = 100M;
        var toPrice = 1000M;
        var results = articles.Range(fromPrice, true, toPrice, true);

        foreach (var item in results)
        {
            Console.WriteLine(string.Join("\n", item.Value));
        }
    }
}