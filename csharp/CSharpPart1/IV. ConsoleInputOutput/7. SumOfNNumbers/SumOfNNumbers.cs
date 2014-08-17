using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int nNum;

        
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            nNum = int.Parse(Console.ReadLine());
            sum += nNum;
        }
        Console.WriteLine("The sum of values is {0}\n", sum);
    }
}

