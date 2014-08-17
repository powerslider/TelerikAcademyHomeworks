using System;

class MaximalIncreasingSequenceCount
{
    static void Main(string[] args)
    {
        Console.Write("Number of array elements: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int counter = 1;
        int maxCount = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == (arr[i - 1] + 1))
            {
                counter++;
                if (maxCount < counter)
                {
                    maxCount = counter;
                }
            }
            else
            {
                counter = 1;
            }
        }
        Console.WriteLine("\nMax sequence count = {0}\n", maxCount);
    }
}

