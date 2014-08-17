using System;

class TriangleArea
{
    static void Main(string[] args)
    {
        Menu();
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("side = ");
                double side = double.Parse(Console.ReadLine());
                Console.Write("altitude = ");
                double altitude = double.Parse(Console.ReadLine());
                Console.WriteLine(GetTriangleArea(side, altitude));
                break;
            case 2:
                Console.Write("first side = ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("second side = ");
                double side2 = double.Parse(Console.ReadLine());
                Console.Write("third side = ");
                double side3 = double.Parse(Console.ReadLine());
                Console.WriteLine(GetTriangleArea(side1, side2, side3)); 
                break;
            case 3:
                Console.Write("first side = ");
                double firstSide = double.Parse(Console.ReadLine());
                Console.Write("second side = ");
                double secondSide = double.Parse(Console.ReadLine());
                Console.Write("angle(in degrees) = ");
                double angle = double.Parse(Console.ReadLine());
                Console.WriteLine(GetTriangleArea2(firstSide, secondSide, angle));
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    static double GetTriangleArea(double side, double altitude)
    {
        return (side * altitude) / 2;
    }

    static double GetTriangleArea(double side1, double side2, double side3)
    {
        double halfPerimeter;
        halfPerimeter = (side1 + side2 + side3) / 2;
        double area = Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
        return area;
    }

    static double GetTriangleArea2(double side1, double side2, double angle)
    {
        angle /= 180/ Math.PI;
        return (side1 * side2 * Math.Sin(angle)) / 2;
    }

    static void Menu()
    {
        Console.WriteLine("Program calculating the area of a triangle: ");
        Console.WriteLine(" 1. Side and altitude");
        Console.WriteLine(" 2. Three sides");
        Console.WriteLine(" 3. Two sides and angle between them");
        Console.Write("choice: ");
    }
}
