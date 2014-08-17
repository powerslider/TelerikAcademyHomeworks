using System;

public class Rectangle : Shape
{
    public Rectangle(double width, double height)
        : base(width, height)
    { 
    }
    
    public override double  CalculateSurface()
    {
        double result = Width * Height;
        return result;
    }   
}

