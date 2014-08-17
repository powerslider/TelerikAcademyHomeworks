using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int i = 0;

        while (i < n)
        {
            i++;
            Console.WriteLine(i);
        }
    }
}

