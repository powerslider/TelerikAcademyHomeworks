using System;

class PrintIntNumbersAndSum
{
    static void Main()
    {
        
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
  
        int s = a + b + c;
        Console.WriteLine("\n{0} + {1} + {2} = {3}\n", a, b, c, s);

    }
}

