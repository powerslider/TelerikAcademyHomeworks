using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("n = ");                  //start number
        int n = int.Parse(Console.ReadLine());
        Console.Write("m = ");                 //end number
        int m = int.Parse(Console.ReadLine());

        if (n > 100)
        {
            Console.WriteLine("Invalid input! Enter a new number:");
            Main();
        }

        for (int num = n; num <= m; num++)
        {
            bool prime = true;
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(num);

            while (divider <= maxDivider)
            {
                if (num % divider == 0)
                {
                    prime = false;
                    break;
                }
                divider++;
                if (prime)
                {
                    Console.Write(" " + num);
                }
            }
        }
    }
}
    
