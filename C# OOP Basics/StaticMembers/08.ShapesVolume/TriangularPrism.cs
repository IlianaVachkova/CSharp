public class TriangularPrism
{
    public TriangularPrism(double baseSide, double height, double length)
    {
        this.BaseSide = baseSide;
        this.Height = height;
        this.Length = length;
    }

    public double BaseSide { get; private set; }

    public double Height { get; private set; }

    public double Length { get; private set; }
}