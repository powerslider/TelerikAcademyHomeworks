using System;

class ExchangeIntValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("a = {0}", a);    // a = 10
        Console.WriteLine("b = {0}", b);    // b = 5

    }
}

