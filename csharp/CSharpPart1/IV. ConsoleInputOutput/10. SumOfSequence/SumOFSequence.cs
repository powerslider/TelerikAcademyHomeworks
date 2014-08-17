using System;

class SumOFSequence
{
    static void Main()
    {
        Console.WriteLine("Enter count of numbers to be summed up:");
        int nCount = int.Parse(Console.ReadLine());
        double nNum, result;
        double nSum = 0;
        double sum = 0;

        Console.Write("1");
        for (int i = 2; i <= nCount; i++)
        {
            if (i % 2 == 0)
            {
                nNum = 1.0 / i;
                Console.Write(" + 1/{0}", i);
                nSum += nNum;
            }
            else
            {
                nNum = 1.0 / (-i);
                Console.Write(" - 1/{0}", i);
                nSum += nNum;
            }
            sum = 1 + nSum;
        }
        Console.Write(" = {0:F3}\n\n", sum);
    }
}
