/*
    Cotton-eye Gosho has a problem. Snakes! An infestation of snakes! Gosho is a red-neck which means he doesn’t really care 
    about animal rights, so he bought some ammo, loaded his shotgun and started shooting at the poor creatures. He has a 
    favorite spot – rectangular stairs which the snakes like to climb in order to reach Gosho’s stash of whiskey in the attic. 
    You’re tasked with the horrible cleanup of the aftermath.
    A snake is represented by a string. The stairs are a rectangular matrix of size NxM. A snake starts climbing the stairs 
    from the bottom-right corner and slithers its way up in a zigzag – first it moves left until it reaches the left wall, 
    it climbs on the next row and starts moving right, then on the third row, moving left again and so on. The first cell 
    (bottom-right corner) is filled with the first symbol of the snake, the second cell (to the left of the first) is filled
    with the second symbol, etc. The snake is as long as it takes in order to fill the stairs completely – if you reach the 
    end of the string representing the snake, start again at the beginning. Gosho is patient and a sadist, he’ll wait until 
    the stairs are completely covered with snake and will then fire a shot.
    The shot has three parameters – impact row, impact column and radius. When the projectile lands on the specified 
    coordinates of the matrix it destroys all symbols in the given radius (turns them into a space). You can check whether 
    a cell is inside the blast radius using the Pythagorean Theorem (very similar to the "point inside a circle" problem).
    The symbols above the impact area start falling down until they land on other symbols (meaning a symbol moves down a 
    row as long as there is a space below). When the horror ends, print on the console the resulting staircase, each row 
    on a new line. You should really check out the examples at this point.
    
    Input
    •	The input data should be read from the console. It consists of exactly three lines.
    •	On the first line, you’ll receive the dimensions of the stairs in format: "N M", where N is the number of rows, 
    and M is the number of columns. They’ll be separated by a single space.
    •	On the second line you’ll receive the string representing the snake.
    •	On the third line, you’ll receive the shot parameters (impact row, impact column and radius), all separated by a 
    single space.
    •	The input data will always be valid and in the format described. There is no need to check it explicitly.
    
    Output
    •	The output should be printed on the console. It should consist of N lines. 
    •	Each line should contain a string representing the respective row of the final matrix.
*/

using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int[] dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x)).ToArray();
        int rows = dimentions[0];
        int cols = dimentions[1];
        char[,] matrix = new char[rows, cols];

        string snake = Console.ReadLine();
        int[] coordinates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x)).ToArray();
        int impactRow = coordinates[0];
        int impactCol = coordinates[1];
        int radius = coordinates[2];

        int snakeLetPos = 0;
        int direction = 1;
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            if (direction % 2 == 1)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    matrix[row, col] = snake[snakeLetPos];
                    snakeLetPos++;
                    snakeLetPos %= snake.Length;
                }
            }
            else if (direction % 2 == 0)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = snake[snakeLetPos];
                    snakeLetPos++;
                    snakeLetPos %= snake.Length;
                }
            }

            direction++;
        }

        int currentRow = 0;
        int currentCol = 0;
        for (int i = 0; i < radius + 1; i++)
        {
            for (int j = 0; j < 2 * radius + 1 - 2 * i; j++)
            {
                currentRow = impactRow + i;
                currentCol = impactCol - radius + i + j;

                if ((currentRow >= 0 && currentRow < rows) && (currentCol >= 0 && currentCol < cols))
                {
                    matrix[currentRow, currentCol] = '\0';
                }

            }
        }

        for (int i = 0; i < radius; i++)
        {
            for (int j = 0; j < 2 * radius - 1 - 2 * i; j++)
            {
                currentRow = impactRow - 1 - i;
                currentCol = impactCol - radius + 1 + i + j;

                if ((currentRow >= 0 && currentRow < rows) && (currentCol >= 0 && currentCol < cols))
                {
                    matrix[currentRow, currentCol] = '\0';
                }
            }
        }

        char[,] resultMatrix = new char[rows, cols];
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            int resultMatrixRow = rows - 1;
            int resultMatrixCol = col;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                if (matrix[row, col] != '\0')
                {
                    resultMatrix[resultMatrixRow, resultMatrixCol] = matrix[row, col];
                    resultMatrixRow--;
                }
            }
        }

        //printing the matrix
        for (int row = 0; row < resultMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < resultMatrix.GetLength(1); col++)
            {
                if (resultMatrix[row, col] != '\0')
                {
                    Console.Write(resultMatrix[row, col]);
                }
                else
                {
                    Console.Write(' ');
                }
            }

            Console.WriteLine();
        }
    }
}

