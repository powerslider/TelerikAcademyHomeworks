using System;

public class Triangle : Shape
{
    public Triangle(double width, double height)
        : base(width, height)
    { 
    }
    
    public override double  CalculateSurface()
    {
        double result = (Width * Height) / 2;
        return result;
    }

    
}

