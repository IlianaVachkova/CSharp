using System;
using System.Linq;
using System.Reflection;

public class Startup
{
    public static void Main()
    {
        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());

        double lenght = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        try
        {
            Box box = new Box(lenght, width, height);
            Console.WriteLine("Surface Area - {0:0.00}", box.SurfaceArea(box));
            Console.WriteLine("Lateral Surface Area - {0:0.00}", box.LateralSurfaceArea(box));
            Console.WriteLine("Volume - {0:0.00}", box.Volume(box));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
