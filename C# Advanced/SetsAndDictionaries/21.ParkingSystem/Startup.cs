/*
    The parking lot in front of SoftUni is one of the busiest in the country, and it’s a common cause for conflicts between 
    the doorkeeper Bai Tzetzo and the students. The SoftUni team wants to proactively resolve all conflicts, so an automated 
    parking system should be implemented. They are organizing a competition – Parkoniada – and the author of the best parking 
    system will win a romantic dinner with RoYaL. That’s exactly what you’ve been dreaming of, so you decide to join in.
    The parking lot is a rectangular matrix where the first column is always free and all other cells are parking spots. A 
    car can enter from any cell of the first column and then decides to go to a specific spot. If that spot is not free, the 
    car searches for the closest free spot on the same row. If all the cells on that specific row are used, the car cannot park 
    and leaves. If two free cells are located at the same distance from the initial parking spot, the cell which is closer to 
    the entrance is preferred. A car can pass through a used parking spot.
    Your task is to calculate the distance travelled by each car to its parking spot.
    A car enters the parking at row 1. It wants to go to cell 2, 2 so it moves through exactly four cells to reach its parking 
    spot.
    
    Input
    •	On the first line of input, you are given the integers R and C, defining the dimensions of the parking lot.
    •	On the next several lines, you are given the integers Z, X, Y where Z is the entry row and X, Y are the coordinates of
        the desired parking spot.
    •	The input stops with the command ‘stop’. All integers are separated by a single space.

    Output
    •	For each car, print the distance travelled to the desired spot or the first free spot.
    •	If a car cannot park on its desired row, print the message ‘Row {row number} full’
*/

using System;

public class Startup
{
    public static void Main()
    {
        string[] coordinates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int rows = int.Parse(coordinates[0]);
        int cols = int.Parse(coordinates[1]);

        bool[,] matrix = new bool[rows, cols];
        long travelledDistance = 0;
        string line = Console.ReadLine();
        bool hasParked = false;
        bool isRowFull = false;
        while (line != "stop")
        {
            string[] parkingSpotCoord = line.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int entryRow = int.Parse(parkingSpotCoord[0]);
            int parkingRow = int.Parse(parkingSpotCoord[1]);
            int parkingCol = int.Parse(parkingSpotCoord[2]);

            for (int i = 1; i < cols; i++)
            {
                if (matrix[parkingRow, i] == false)
                {
                    isRowFull = false;
                    break;
                }
                else if (matrix[parkingRow, i] == true)
                {
                    isRowFull = true;
                }
            }

            if (isRowFull)
            {
                Console.WriteLine("Row {0} full", parkingRow);
                isRowFull = false;
            }

            if (matrix[parkingRow, parkingCol] == false)
            {
                travelledDistance = Math.Abs(parkingCol + 1) + Math.Abs(parkingRow - entryRow);
                Console.WriteLine(travelledDistance);
                matrix[parkingRow, parkingCol] = true;
            }
            else
            {
                //checking left part
                for (int i = 1; i <= parkingCol - 1; i++)
                {
                    if (matrix[parkingRow, parkingCol - i] == false && hasParked == false)
                    {
                        travelledDistance = Math.Abs(parkingCol - i + 1) + Math.Abs(parkingRow - entryRow);
                        Console.WriteLine(travelledDistance);
                        matrix[parkingRow, parkingCol - i] = true;
                        hasParked = true;
                        break;
                    }
                }

                //checking right part
                for (int i = 1; i <= cols - parkingCol - 1; i++)
                {
                    if (matrix[parkingRow, parkingCol + i] == false && hasParked == false)
                    {
                        travelledDistance = Math.Abs(parkingCol + i + 1) + Math.Abs(parkingRow - entryRow);
                        Console.WriteLine(travelledDistance);
                        matrix[parkingRow, parkingCol + i] = true;
                        hasParked = true;
                        break;
                    }
                }

                hasParked = false;
            }

            line = Console.ReadLine();
        }
    }
}