using System;

namespace WalkInMatrix
{
    public class Startup
    {
        public static void Main()
        {
            int matrixSize = GetMatrixSize();
            Matrix matrix = new Matrix(matrixSize);
            matrix.DoRotateInMatrix();
            Console.WriteLine(matrix);
        }

        private static int GetMatrixSize()
        {
            Console.Write("Enter the size of the matrix number: ");
            string input = Console.ReadLine();
            int matrixSize = 0;

            while (!int.TryParse(input, out matrixSize) || matrixSize < Matrix.MinSize || matrixSize > Matrix.MaxSize)
            {
                Console.WriteLine("\nYou haven't entered a correct positive number");
                Console.Write("Enter the size of the matrix number: ");
                input = Console.ReadLine();
            }

            return matrixSize;
        }
    }
}
