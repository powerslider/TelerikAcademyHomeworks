using System;

class PrintGreaterNumbers
{
    static void Main()
    {
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("y = ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Greater = {0}", Math.Max(x,y));
        Console.WriteLine("Smaller = {0}\n", Math.Min(x,y));

    }
}

