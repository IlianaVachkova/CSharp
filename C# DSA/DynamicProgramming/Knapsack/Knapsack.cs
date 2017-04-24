/* For more info: http://www.youtube.com/watch?v=hugQNiYoqUA
 * This helped me a lot.
 */

using System;
using System.Collections.Generic;

public class Knapsack
{
    public static void Main()
    {
        var beer = new Product("Beer", 3, 2);
        var vodka = new Product("Vodka", 8, 12);
        var cheese = new Product("Cheese", 4, 5);
        var nuts = new Product("Nuts", 1, 4);
        var ham = new Product("Ham", 2, 3);
        var whiskey = new Product("Whiskey", 8, 13);
        var products = new Product[] { beer, vodka, cheese, nuts, ham, whiskey };

        int capacity = 10;
        int[,] costMatrix = new int[products.Length + 1, capacity + 1];
        int[,] productMatrix = new int[products.Length + 1, capacity + 1];

        // we are filling the tow matrices
        for (int row = 1; row < costMatrix.GetLength(0); row++)
        {
            for (int col = 1; col < costMatrix.GetLength(1); col++)
            {
                if (products[row - 1].Weight <= col &&
                    products[row - 1].Cost + costMatrix[row - 1, col - products[row - 1].Weight] >= costMatrix[row - 1, col])
                {
                    costMatrix[row, col] = products[row - 1].Cost + costMatrix[row - 1, col - products[row - 1].Weight];
                    productMatrix[row, col] = 1;
                }
                else
                {
                    costMatrix[row, col] = costMatrix[row - 1, col];
                }
            }
        }

        // we are taking the products that fit best
        var resultProducts = new List<Product>();
        int column = productMatrix.GetLength(1) - 1;
        for (int row = productMatrix.GetLength(0) - 1; row >= 0; row--)
        {
            if (productMatrix[row, column] == 1)
            {
                var productToAdd = products[row - 1];
                resultProducts.Add(productToAdd);
                column -= productToAdd.Weight;
            }
        }

        Console.WriteLine(string.Join("\n", resultProducts));
    }
}