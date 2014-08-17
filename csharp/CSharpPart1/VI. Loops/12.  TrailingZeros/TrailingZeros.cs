using System;
using System.Numerics;

    class TrailingZeros
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger nFactoriel = 1;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                nFactoriel *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                sum += n / (int)Math.Pow(5, i);
                if (sum < 1)
                    break;
            }
            if (sum == 1)
            {
                Console.WriteLine("\n{0}! has {1} trailing zero!!!\n", n, sum);
            }
            else
            {
                Console.WriteLine("\n{0}! has {1} trailing zeros!!!\n", n, sum);
            }           
        }
    }

