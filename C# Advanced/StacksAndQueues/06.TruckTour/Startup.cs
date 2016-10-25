/*
    Suppose there is a circle. There are N petrol pumps on that circle. Petrol pumps are 
    numbered 0 to (N−1) (both inclusive). You have two pieces of information corresponding 
    to each of the petrol pump: (1) the amount of petrol that particular petrol pump will 
    give, and (2) the distance from that petrol pump to the next petrol pump.
    Initially, you have a tank of infinite capacity carrying no petrol. You can start the 
    tour at any of the petrol pumps. Calculate the first point from where the truck will be 
    able to complete the circle. Consider that the truck will stop at each of the petrol pumps. 
    The truck will move one kilometer for each liter of the petrol.

    Input Format: The first line will contain the value of N.
    The next N lines will contain a pair of integers each, i.e. the amount of petrol that petrol 
    pump will give and the distance between that petrol pump and the next petrol pump.

    Output Format: An integer which will be the smallest index of the petrol pump from which we can start the tour.

    Constraints: 
    1 ≤ N ≤ 1000001
    1 ≤ amount of petrol, distance ≤ 1000000000

    Input:	Output:
    3       1
    1 5
    10 3
    3 4
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Queue<long> amountOfPetrol = new Queue<long>();
        Queue<long> distances = new Queue<long>();
        long currentAmount = 0;
        long currentDistance = 0;
        long leftPetrol = 0;
        long currentPosition = 0;
        long wantedPosition = 0;

        for (long i = 0; i < n; i++)
        {
            long[] amountAndDistance = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => long.Parse(x)).ToArray();
            currentAmount = amountAndDistance[0];
            currentDistance = amountAndDistance[1];

            if ((currentAmount + leftPetrol) >= currentDistance)
            {
                leftPetrol += (currentAmount - currentDistance);
            }
            else
            {


                currentAmount = amountOfPetrol.Dequeue();
                currentDistance = distances.Dequeue();

                wantedPosition = currentPosition + 1;

                amountOfPetrol.Enqueue(currentAmount);
                distances.Enqueue(currentDistance);
            }

            amountOfPetrol.Enqueue(currentAmount);
            distances.Enqueue(currentDistance);
        }

        while (true)
        {
            if (wantedPosition == currentPosition && ((currentAmount + leftPetrol) < currentDistance) && wantedPosition >= n && currentPosition >= n)
            {
                break;
            }

            currentAmount = amountOfPetrol.Peek();
            currentDistance = distances.Peek();

            if ((currentAmount + leftPetrol) >= currentDistance)
            {
                leftPetrol += (currentAmount - currentDistance);
            }
            else
            {
                currentAmount = amountOfPetrol.Dequeue();
                currentDistance = distances.Dequeue();

                wantedPosition = currentPosition + 1;

                amountOfPetrol.Enqueue(currentAmount);
                distances.Enqueue(currentDistance);
            }

            currentPosition++;
        }

        Console.WriteLine(wantedPosition);
    }
}

