using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Enter rectangle width: ");
        string a = Console.ReadLine();
        int aNum = int.Parse(a);

        Console.Write("Enter rectangle height: ");
        string b = Console.ReadLine();
        int bNum = int.Parse(b);
        Console.WriteLine("\n");

        int S;
        S = aNum * bNum;
        Console.WriteLine("S = " + S + "cm^2"+"\n");

    }
}

