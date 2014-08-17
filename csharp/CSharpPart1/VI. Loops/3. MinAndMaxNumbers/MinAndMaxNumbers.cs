using System;

class MinAndMaxNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
     
        Console.WriteLine("Enter \"n\" numbers: \n");
        Console.Write("n1 = ");
        int nNum = int.Parse(Console.ReadLine());
        int max = nNum;
        int min = nNum;
        for (int i = 2; i <= n; i++)
        {
            Console.Write("n{0} = ", i);
            nNum = int.Parse(Console.ReadLine());
            if (max < nNum)
            {
                max = nNum;
            }
            if (min > nNum)
            {
                min = nNum;
            }
        }
        Console.WriteLine("\nMax value is: {0}", max);
        Console.WriteLine("Min value is: {0}\n", min);
    }
}
