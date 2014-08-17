using System;
using System.Numerics;

class NthCatalanNumberCalc
{
    static void Main()
    {
        Console.Write("n = ");
        BigInteger n = int.Parse(Console.ReadLine());
        BigInteger nFactoriel = 1;
        BigInteger twoNFactoriel = 1;
        BigInteger result;

        if (n < 1)
        {
            Console.WriteLine("Incorrect input! Enter new number:");
            Main();
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                nFactoriel *= i;
            }
            for (int i = 1; i <= (2 * n); i++)
            {
                twoNFactoriel *= i;
            }
            result = twoNFactoriel / ((n + 1) * nFactoriel * nFactoriel);

            Console.WriteLine("\nC{0} = {1}\n", n, result);
        }
    }
}

