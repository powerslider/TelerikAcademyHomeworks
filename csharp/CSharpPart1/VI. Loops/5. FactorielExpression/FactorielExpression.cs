using System;

class FactorielExpression
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int nFactoriel = 1;
        int kFactoriel = 1;
        int result;

        if (n > 1 && n < k)
        {
            for (int i = 1; i <= n; i++)
            {
                nFactoriel *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                kFactoriel *= j;
            }
            result = (nFactoriel * kFactoriel) / (k - n);
            Console.WriteLine("\nEnd result: {0}\n", result);
        }
        else
        {
            Console.WriteLine("\nERROR\n");
        }
    }
}


