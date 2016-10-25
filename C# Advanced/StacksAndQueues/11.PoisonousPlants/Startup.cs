/*
    You are given N plants in a garden. Each of these plants has been added with some amount of pesticide. After each day, 
    if any plant has more pesticide than the plant at its left, being weaker(more GMO) than the left one, it dies. You are 
    given the initial values of the pesticide and position of each plant. Print the number of days after which no plant dies, 
    i.e. the time after which there are no plants with more pesticide content than the plant to their left.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int numOfPlants = int.Parse(Console.ReadLine());
        int[] pesticidesOfEachPlant = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x)).ToArray();
        Queue<int> plants = new Queue<int>();

        int days = 0;
        bool hasPlantDie = false;
        int currentPlant = pesticidesOfEachPlant[pesticidesOfEachPlant.Length - 1];

        for (int i = pesticidesOfEachPlant.Length - 2; i >= 0; i--)
        {
            if (currentPlant > pesticidesOfEachPlant[i])
            {
                hasPlantDie = true;
            }
            else
            {
                plants.Enqueue(currentPlant);
            }

            currentPlant = pesticidesOfEachPlant[i];
        }

        plants.Enqueue(pesticidesOfEachPlant[0]);

        if (hasPlantDie)
        {
            days = 1;
            hasPlantDie = false;
        }

        while (plants.Count > 1)
        {
            int lenght = plants.Count;

            currentPlant = plants.Dequeue();
            for (int i = 0; i < lenght - 1; i++)
            {
                int leftPlant = plants.Dequeue();
                if (currentPlant > leftPlant)
                {
                    hasPlantDie = true;
                }
                else
                {
                    plants.Enqueue(currentPlant);
                }

                currentPlant = leftPlant;
            }

            plants.Enqueue(currentPlant);

            if (hasPlantDie)
            {
                days++;
                hasPlantDie = false;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(days);
    }
}
