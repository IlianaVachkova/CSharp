using System;

public class Startup
{
    public static void Main()
    {
        string line = Console.ReadLine();
        while (line != "End")
        {
            string[] lineAsArr = line.Split();
            string figure = lineAsArr[0];
            switch (figure)
            {
                case "Cube":
                    Console.WriteLine("{0:0.000}", VolumeCalculator.Cube(new Cube(double.Parse(lineAsArr[1]))));
                    break;
                case "Cylinder":
                    Console.WriteLine("{0:0.000}", VolumeCalculator.Cylinder(new Cylinder(double.Parse(lineAsArr[1]), double.Parse(lineAsArr[2]))));
                    break;
                case "TrianglePrism":
                    Console.WriteLine("{0:0.000}", VolumeCalculator.TriangularPrism(new TriangularPrism(double.Parse(lineAsArr[1]), double.Parse(lineAsArr[2]), double.Parse(lineAsArr[3]))));
                    break;
            }

            line = Console.ReadLine();
        }
    }
}
