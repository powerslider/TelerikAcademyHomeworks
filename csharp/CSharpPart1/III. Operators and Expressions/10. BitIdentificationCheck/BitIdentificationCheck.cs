using System;

class BitIdentificationCheck
{
    static void Main()
    {
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("v = ");
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int vAndMask = v & mask;
        int bit = vAndMask >> p;
        Console.WriteLine(bit);

        bool bitCheck = (bit == 1);
        Console.WriteLine(bitCheck);
    }
}

