using System;
using System.Text;

namespace WalkInMatrix
{
    public class Matrix
    {
        public const int MinSize = 1;
        public const int MaxSize = 100;

        private int[,] matrix;
        private Cell cell;
        private Direction direction;
        private int size;

        public Matrix(int size)
        {
            this.Size = size;
            this.matrix = new int[size, size];
            this.cell = new Cell(0, 0, 1);
            this.direction = new Direction(1, 1);
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value < MinSize || value > MaxSize)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format(
                            "Wrong matrix size: {0}. Size of the matrix should be in the range[{1}..{2}]",
                            this.size, 
                            MinSize, 
                            MaxSize));
                }

                this.size = value;
            }
        }

        public int[,] DoRotateInMatrix()
        {
            while (true)
            {
                this.matrix[this.cell.Row, this.cell.Col] = this.cell.Value;
                if (!this.IsThereFreeCell())
                {
                    this.cell.Value++;

                    if (this.cell.Value < this.Size * this.Size)
                    {
                        this.FindEmptyCell();

                        this.direction.X = 1;
                        this.direction.Y = 1;

                        continue;
                    }

                    break;
                }

                while (!(this.IsNextCellInBoundries(this.direction) &&
                    this.IsNextCellFree(this.direction)))
                {
                    this.direction.GetNext();
                }

                this.cell.Row += this.direction.X;
                this.cell.Col += this.direction.Y;
                this.cell.Value++;
            }

            return this.matrix;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    result.AppendFormat("{0,3}", this.matrix[row, col]);
                }

                result.AppendLine();
            }

            result.Length -= 2;

            return result.ToString();
        }

        private bool IsNextCellInBoundries(Direction currDirection)
        {
            bool isCellRowInMatrix = this.cell.Row + currDirection.X < this.matrix.GetLength(0) &&
                this.cell.Row + currDirection.X >= 0;
            bool isCellColInMatrix = this.cell.Col + currDirection.Y < this.matrix.GetLength(1) &&
                this.cell.Col + currDirection.Y >= 0;

            return isCellRowInMatrix && isCellColInMatrix;
        }

        private bool IsNextCellFree(Direction currDirection)
        {
            return this.matrix[this.cell.Row + currDirection.X, this.cell.Col + currDirection.Y] == 0;
        }

        private bool IsThereFreeCell()
        {
            for (int directionIndex = 0; directionIndex < Direction.DeltasX.Length; directionIndex++)
            {
                Direction currDirection = new Direction(
                    Direction.DeltasX[directionIndex], Direction.DeltasY[directionIndex]);

                if (this.IsNextCellInBoundries(currDirection) &&
                    this.IsNextCellFree(currDirection))
                {
                    return true;
                }
            }

            return false;
        }

        private void FindEmptyCell()
        {
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    if (this.matrix[row, col] == 0)
                    {
                        this.cell.Row = row;
                        this.cell.Col = col;
                        return;
                    }
                }
            }
        }
    }
}
