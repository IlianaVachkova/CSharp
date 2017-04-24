/*PSEUDO CODE OF THE ALGORITHM------------------------------
void пореднаЦарица(i) { / поставяне на царица в i-тия ред /
    if (i > n) { Печатаме решението; }
    for (всеки_незает_от_царица_стълб_k)
        if (няма_царица_върху_диагонал_през_(i,k)) {
            / позицията (i,k) е безопасна /
            Поставяме_i-тата_царица_на_позиция_(i,k);
            пореднаЦарица(i+1);
            Отстраняваме_i-тата_царица_от_позиция_(i,k);
    }
}
PSEUDO CODE  OF THE ALGORITHM------------------------------*/
// Page 389 - Programming ++= Algorithms by Preslav Nakov

using System;

public class EightQueensPuzzle
{
    public static int[,] matrix = new int[8, 8];
    public static int[] columnsTaken = new int[8];

    public static void Main()
    {
        NextQueen(0);
    }

    public static void NextQueen(int row)
    {
        if (row >= matrix.GetLength(0))
        {
            PrintMatrix();
            return;
        }
        else
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (columnsTaken[col] == 0 && CheckDiagonals(row, col))
                {
                    columnsTaken[col] = 1;
                    matrix[row, col] = 1; // we put 1 to set the cell full
                    NextQueen(row + 1);
                    matrix[row, col] = 0; // we empty the cell on our way back
                    columnsTaken[col] = 0;
                }
            }
        }
    }

    public static bool CheckDiagonals(int row, int col)
    {
        int[] dirX = { 1, 1, -1, -1 };
        int[] dirY = { 1, -1, 1, -1 };

        for (int i = 0; i < dirX.Length; i++)
        {
            int nextRow = row + dirX[i];
            int nextCol = col + dirY[i];
            while (IsInRange(nextRow, nextCol))
            {
                if (matrix[nextRow, nextCol] == 1)
                {
                    return false;
                }
                nextRow += dirX[i];
                nextCol += dirY[i];
            }
        }

        return true;
    }

    public static bool IsInRange(int row, int col)
    {
        return row < matrix.GetLength(0) && row >= 0 &&
            col < matrix.GetLength(1) && col >= 0;
    }

    public static void PrintMatrix()
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}