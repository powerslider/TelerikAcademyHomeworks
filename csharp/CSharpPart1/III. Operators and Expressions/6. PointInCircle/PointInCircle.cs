using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter the X & Y coordinates: ");
       
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("y = ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        int radius = 5;
       
        bool result = (x * x + y * y) <= radius * radius;
        Console.WriteLine(result ? "The given coordinates are within the circle!" : "The given coordinates are outside the circle!");
        Console.WriteLine();
    }
}

