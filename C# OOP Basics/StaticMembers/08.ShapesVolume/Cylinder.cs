public class Cylinder
{
    public Cylinder(double radius, double height)
    {
        this.Radius = radius;
        this.Height = height;
    }

    public double Radius { get; private set; }

    public double Height { get; private set; }
}