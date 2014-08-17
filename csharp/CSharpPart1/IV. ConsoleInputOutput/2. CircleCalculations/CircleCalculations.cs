using System;

class CircleCalculations
{
    static void Main()
    {
        Console.Write("r = ");
        float r = float.Parse(Console.ReadLine());
        double C = 2 * Math.PI * r;
        double S = Math.PI * r * r;

        Console.WriteLine("\nC = {0} cm", C);
        Console.WriteLine("S = {0} cm^2\n", S);
    }
}

