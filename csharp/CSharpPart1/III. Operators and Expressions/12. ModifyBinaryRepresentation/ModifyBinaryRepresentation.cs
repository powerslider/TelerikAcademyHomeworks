using System;

class ModifyBinaryRepresentation
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("v = ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
       
        int mask = 1 << p;
        int maskCheck = ((mask & n) != 0 ? 1 : 0);

        Console.WriteLine("\nInput number in decimal format: {0}", Convert.ToString(n, 10));
        Console.WriteLine("Input number in binary format: {0}", Convert.ToString(n, 2).PadLeft(10, '0'));
        if (maskCheck == 0)
        {
           n |= (1 << p);
        }
        else 
        {
           n &= ~(1 << p);
        }
        Console.WriteLine("\nOutput number in binary format: {0}", Convert.ToString(n, 2).PadLeft(10, '0'));
        Console.WriteLine("Output number in decimal format: {0} \n", Convert.ToString(n, 10));
    }
}

