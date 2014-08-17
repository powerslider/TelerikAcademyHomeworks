using System;

class ExchangeValuesWhenGreater
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("\nA is now assigned with the value from B:\na = {0}\n", b);
            b = a;
            Console.WriteLine("\nB is now assigned with the value from A:\nb = {0}\n", b);         
        }
        else
        {
            Console.WriteLine("\nERROR\n");
        }
    }
}

