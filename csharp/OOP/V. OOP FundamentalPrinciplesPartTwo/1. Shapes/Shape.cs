using System;

public abstract class Shape
{
    protected double Width { get; set; }
    protected double Height { get; set; }
   
    public Shape(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public Shape(double width)
    {
        this.Width = width;
    }

    public abstract double CalculateSurface();
    
    public override string ToString()
    {
        string result = String.Format("The {0}'s surface equals {1:F2} cm^2.",
            this.GetType(), this.CalculateSurface());

        return result;
    }
    
}

