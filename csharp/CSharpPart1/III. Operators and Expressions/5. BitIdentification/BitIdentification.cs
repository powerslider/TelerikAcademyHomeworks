using System;

class BitIdentification
{
    static void Main()
    {
        int p = 3;
        string q = Console.ReadLine();
        int qNum = int.Parse(q);
        int mask = 1 << p;
        int qNumAndMask = qNum & mask;
        int bit = qNumAndMask >> p;
        Console.WriteLine(bit);
    }
}

