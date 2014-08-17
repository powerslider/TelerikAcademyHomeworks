using System;

class QuadraticEquation
{
    static void Main()
    {
         Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("\n{0}x^2+{1}x+{2} = 0\n", a, b, c);

        float D, x1, x2;
        int k = 3;

        if (a != 0)
        {

            D = b * b - 4 * a * c;
            if (D < 0)
                k = 1;
            if (D == 0)
                k = 2;
            if (D > 0)
                k = 3;

            switch (k)
            {
                case 1:
                    Console.WriteLine("Imaginary Solution\n");
                    break;
                case 2:
                    x1 = (-b) / (2 * a);
                    Console.WriteLine("x1 = x2 = {0}\n", x1);
                    break;
                case 3:
                    x1 = (-b + (float)(Math.Sqrt(D))) / (2 * a);
                    x2 = (-b - (float)(Math.Sqrt(D))) / (2 * a);
                    Console.WriteLine("x1 = {0:F2}", x1);
                    Console.WriteLine("x2 = {0:F2}\n", x2);
                    break;
            }
        }
        else
        {
            Console.WriteLine("This is not a quadratic equation!!!");
        }
    }
}
    

