using System;

class ZeroSumSubsets
{
    static void Main()
    {
        int[] array = new int[5];
        for (int i = 0; i < 5; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                sum = array[i] + array[j];
                Console.WriteLine("[{0}] + [{1}] = {2}", i, j, sum);
                if (sum == 0) count++;

                for (int k = j + 1; k < array.Length; k++)
                {
                    sum += array[k];
                    Console.WriteLine("[{0}] + [{1}] + [{2}] = {3}", i, j, k, sum);
                    if (sum == 0) count++;

                    for (int l = k + 1; l < array.Length; l++)
                    {
                        sum += array[l];
                        Console.WriteLine("[{0}] + [{1}] + [{2}] + [{3}] = {4}", i, j, k, l, sum);
                        if (sum == 0) count++;

                        for (int m = l + 1; m < array.Length; m++)
                        {
                            sum += array[m];
                            Console.WriteLine("[{0}] + [{1}] + [{2}] + [{3}] + [{4}] = {5}", i, j, k, l, m, sum);
                            if (sum == 0) count++;
                        }
                    }
                }
            }
        }
        Console.WriteLine("The count of the zero sum subsets is {0}", count);
    }
}



