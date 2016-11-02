namespace WalkInMatrix
{
    public class Direction
    {
        private static int[] deltasX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private static int[] deltasY = { 1, 0, -1, -1, -1, 0, 1, 1 };

        public Direction()
        {
        }

        public Direction(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static int[] DeltasX
        {
            get
            {
                int[] result = new int[deltasX.Length];

                for (int i = 0; i < deltasX.Length; i++)
                {
                    result[i] = deltasX[i];
                }

                return result;
            }
        }

        public static int[] DeltasY
        {
            get
            {
                int[] result = new int[deltasY.Length];

                for (int i = 0; i < deltasY.Length; i++)
                {
                    result[i] = deltasY[i];
                }

                return result;
            }
        }

        public int X { get; set; }

        public int Y { get; set; }

        public void GetNext()
        {
            int directionIndex = 0;

            for (int i = 0; i < deltasX.Length; i++)
            {
                if (deltasX[i] == this.X &&
                    deltasY[i] == this.Y)
                {
                    directionIndex = i;
                    break;
                }
            }

            if (directionIndex == deltasX.Length - 1)
            {
                this.X = deltasX[0];
                this.Y = deltasY[0];
            }
            else
            {
                this.X = deltasX[directionIndex + 1];
                this.Y = deltasY[directionIndex + 1];
            }
        }
    }
}
