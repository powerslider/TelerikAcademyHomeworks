using System;

public class Circle : Shape
{               
    public Circle(double radius)
        : base(radius)
    { 
    }
    
    public override double  CalculateSurface()
    {
        double result = Math.PI * this.Width * this.Width;
        return result;
    }
}

