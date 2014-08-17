using System;

class BitExtraction
{
    static void Main()
    {
        Console.Write("i = ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        
        int mask = 1 << b;
        int iAndMask = i & mask;
        int value = iAndMask >> b;
        Console.WriteLine("value = {0}", value);
    }
}
