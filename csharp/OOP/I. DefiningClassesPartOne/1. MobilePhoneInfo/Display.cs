using System;

public class Display
{
    private double? size;
    private long? numberOfColors;

    public Display(double? size, long? numberOfColors)
    {
        this.size = size;
        this.numberOfColors = numberOfColors;
    }

    public Display(double? size)
        : this(size, null)
    {
    }

    public Display()
        : this(null)
    {
    }

    public double? Size
    {
        get { return this.size; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("The size should be positive number!");
            }
            this.size = value;
        }
    }

    public long? NumberOfColors
    {
        get
        {
            return this.numberOfColors;
        }
        set
        {
            if (value < 2)
            {
                throw new ArgumentException("There should be at least two colours!");
            }
            this.numberOfColors = value;
        }
    }
}

