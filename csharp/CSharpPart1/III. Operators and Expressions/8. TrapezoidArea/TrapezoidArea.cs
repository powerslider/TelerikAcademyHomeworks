using System;

    class TrapezoidArea
    {
        static void Main()
        {
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("h = ");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float S;

            S = (a + b) / 2* h;
            Console.WriteLine("S = {0} cm^2", S);
        }
    }

