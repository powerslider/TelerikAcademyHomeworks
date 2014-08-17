using System;

    class PointInCircleAndOutOfRectangle
    {
        static void Main()
        {
            Console.WriteLine("Enter the X & Y coordinates: ");

            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int radius = 3;

            bool result = ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= radius * radius) && !(((x >= -1 && x <= 4) && (y >= -1 && y <= 1)));
            Console.WriteLine(result ? "The given coordinates are within the circle and outside the rectangle!" : "ERROR");
            Console.WriteLine();
        }
    }
