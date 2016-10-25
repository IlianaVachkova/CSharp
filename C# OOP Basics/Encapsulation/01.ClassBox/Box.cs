using System;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double Length
    {
        get
        {
            return this.length;
        }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }

            this.length = value;
        }
    }

    public double Width
    {
        get
        {
            return this.width;
        }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }

            this.width = value;
        }
    }

    public double Height
    {
        get
        {
            return this.height;
        }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }

            this.height = value;
        }
    }

    internal double SurfaceArea(Box box)
    {
        return 2 * box.length * box.width + 2 * box.length * box.height + 2 * box.width * box.height;
    }

    internal double LateralSurfaceArea(Box box)
    {
        return 2 * box.length * box.height + 2 * box.width * box.height;
    }

    internal double Volume(Box box)
    {
        return box.length * box.width * box.height;
    }
}