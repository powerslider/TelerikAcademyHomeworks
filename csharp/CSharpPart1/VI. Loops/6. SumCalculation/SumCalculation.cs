using System;

class SumCalculation
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        int nFactoriel = 1;
        int nExponent = 1;
        double sum = 0; 
        double temp, result;

        if (n <= 0 || x <= 0)
        {
            Console.WriteLine("\nIncorrect Input!Enter new values:\n");
            Main();
        }
        else
        { 
            for (int i = 1; i <= n; i++)
            {
                nFactoriel *= i;
                nExponent *= i;
                temp = nFactoriel / Math.Pow(x, nExponent);
                sum += temp;
            }
            result = 1 + sum;
            Console.WriteLine("\nEnd result: {0}\n", result);
        }    
   }
}

