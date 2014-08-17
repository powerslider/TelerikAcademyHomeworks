using System;

class RealNumberSignDefinition
{
    static void Main()
    {
        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine());
        
        bool plus = true;
        bool minus = false;

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("\nThe product of the numbers is zero.\n");
        }
        else
        {
            if (a < 0)
            {
                plus = minus;
            }
            if (b < 0)
            {
                plus = minus;
            }
            if (c < 0)
            {
                plus = minus;
            }
            Console.WriteLine("\nThe sign of the product of the numbers is {0}.\n", plus ? "'+'" : "'-'");
        }

    }

}