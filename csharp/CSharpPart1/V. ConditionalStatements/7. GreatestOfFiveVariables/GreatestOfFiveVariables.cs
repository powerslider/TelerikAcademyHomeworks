using System;

class GreatestOfFiveVariables
{
    static void Main()
    {
        int greatest = 0;
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        int e = int.Parse(Console.ReadLine());

        if (greatest < a)
        {
            greatest = a;
        }
        if (greatest < b)
        {
            greatest = b;
        }
        if (greatest < c)
        {
            greatest = c;
        }
        if (greatest < d)
        {
            greatest = d;
        }
        if (greatest < e)
        {
            greatest = e;
        }
        Console.WriteLine("The greatest number is: {0}\n", greatest);
    }
}

