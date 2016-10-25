using System;

public class VolumeCalculator
{
    public static double TriangularPrism(TriangularPrism triangularPrism)
    {
        return 0.5 * triangularPrism.Height * triangularPrism.Length * triangularPrism.BaseSide;
    }

    public static double Cube(Cube cube)
    {
        return cube.Side * cube.Side * cube.Side;
    }

    public static double Cylinder(Cylinder cylinder)
    {
        return Math.PI * cylinder.Radius * cylinder.Radius * cylinder.Height;
    }
}