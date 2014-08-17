using System;

class Matrix
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        if (n > 20)
        {
            Console.WriteLine("Incorrect input! Enter new number:");
            Main();
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = i; j <= n + (i - 1); j++)
                {
                    Console.Write("{0, 2} ", j);
                }             
            }
             Console.WriteLine("\n");

        }
    }
}
           
        

