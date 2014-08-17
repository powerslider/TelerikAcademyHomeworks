using System;

class ExchangeAllBits
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Input number in binary format:  {0}", Convert.ToString(n, 2).PadLeft(32, '0'));

        Console.Write("Input bit to start: \np = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Input bit to end: \nq = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Input number of exchanged bits: \nk = ");
        int k = int.Parse(Console.ReadLine());
       
        int maskP = 0;
        int mask;
        for (int i = 0; i < k; i++)
        {
            mask = 1 << p + i;
            maskP = maskP | mask;
        }
        int maskQ = 0;
        for (int i = 0; i < k; i++)
        {
            mask = 1 << q + i;
            maskQ = maskQ | mask;
        }
        int maskOnes = ~(maskP | maskQ);

        maskP = n & maskP;           
        maskQ = n & maskQ;
        maskP = maskP >> p;               
        maskQ = maskQ >> q;
        maskP = maskP << q;               
        maskQ = maskQ << p;
        mask = maskQ | maskP;

        int result = n & maskOnes; 
        result = result | mask;          

        Console.WriteLine("Input number = {0}({1})", n, Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("Output number = {0}({1})", result, Convert.ToString(result, 2).PadLeft(32, '0')); 
    }
}


