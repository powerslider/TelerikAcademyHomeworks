using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());
        int temp = 0;

        if (n == 0 || m == 0)
        {
            Console.WriteLine("Enter two positive numbers:");
            Main();
        }
        else
        {
            while (n > m || m > n)
            {
                while ((n - m) > 0)
                {
                    n = n - m;
                }
                while ((m - n) > 0)
                {
                    m = m - n;
                }
            }
            Console.WriteLine("Greatest common divisor = {0}\n", n);
        }
    }
}

