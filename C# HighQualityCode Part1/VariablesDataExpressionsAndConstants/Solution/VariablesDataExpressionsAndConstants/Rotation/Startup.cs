using System;

namespace Rotation
{
    public class Startup
    {
        private static Size GetRotatedSize(Size figureSize, double angelInRadians)
        {
            double figureWidth =
                Math.Abs(Math.Cos(angelInRadians)) * figureSize.width +
                Math.Abs(Math.Sin(angelInRadians)) * figureSize.height;
            double figureHeight =
                Math.Abs(Math.Sin(angelInRadians)) * figureSize.width +
                Math.Abs(Math.Cos(angelInRadians)) * figureSize.height;

            Size rotatedSize = new Size(figureWidth, figureHeight);

            return rotatedSize;
        }

        static void Main()
        {
            Size rotatedSize = GetRotatedSize(new Size(2.34, 5.34), 23);
            Console.WriteLine(
                "Rotatetd size is:\n  width: {0:0.00}\n height: {1:0.00}",
                rotatedSize.width, rotatedSize.height);
        }
    }
}
