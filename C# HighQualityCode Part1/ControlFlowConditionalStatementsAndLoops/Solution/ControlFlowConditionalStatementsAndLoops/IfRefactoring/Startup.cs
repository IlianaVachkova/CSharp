using System;

namespace IfRefactoring
{
    public class Startup
    {
        private const int MinX = 1;
        private const int MaxX = 10;
        private const int MinY = 0;
        private const int MaxY = 20;

        public static void Main()
        {
            // first task
            Potato potato = new Potato();
            potato.IsPeeled = true;

            if (potato != null)
            {
                if (potato.IsPeeled && !potato.IsRed)
                {
                    Cook(potato);
                }
            }

            // second task
            int x = 3;
            int y = 5;
            bool isCellVisited = false;
            bool isInRangeX = MinX <= x && x <= MaxX;
            bool isInRangeY = MinY <= y && y <= MaxY;

            if (isInRangeX && isInRangeY && !isCellVisited)
            {
                VisitCell();
            }
        }

        private static void Cook(Potato potato)
        {
            Console.WriteLine("{0} is cooked.", potato.GetType().Name);
        }

        private static void VisitCell()
        {
            Console.WriteLine("Cell visited.");
        }
    }
}