using System;

public class TestShapes
{
    static void Main()
    {
        Shape[] shapes = 
        {
            new Triangle(2.36, 4.52),
            new Circle(5.356),
            new Rectangle(8.654, 19.254)
        };

        foreach (var shape in shapes)
	    {
		    Console.WriteLine(shape);
	    }
        Console.WriteLine();
    }
}

