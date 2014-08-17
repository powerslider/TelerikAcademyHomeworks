using System;

class PrintGreaterNumbers
{
    static void Main()
    {
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("y = ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("GreaterX = {0}", ++x);
        Console.WriteLine("GreaterY = {0}", ++y);

    }
}

