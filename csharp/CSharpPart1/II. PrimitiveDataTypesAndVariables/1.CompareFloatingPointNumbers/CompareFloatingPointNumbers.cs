using System;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        float a = 5.3f;
        float b = 6.01f;
        bool equalAB = (Math.Abs(a-b) < 0.000001f);

        float c = 5.00000001f;
        float d = 5.00000003f;
        bool equalCD = (Math.Abs(c-d) < 0.000001f);

        Console.WriteLine("5.3 = 6.01 " + equalAB);
        Console.WriteLine("5.00000001 = 5.00000003 " + equalCD);
    }
}

