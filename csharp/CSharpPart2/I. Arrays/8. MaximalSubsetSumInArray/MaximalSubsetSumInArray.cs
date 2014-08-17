using System;

class MaximalSubsetSumInArray
{
    static void Main()
    {
        //Console.Write("Number of array elements: ");
        //int N = int.Parse(Console.ReadLine());

        //int[] arr = new int[N];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
            
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int sum = 0;
        int oldSum = 0;
        int maxSum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            oldSum = sum - arr[i];
            if (sum < 0)
            {
                sum = 0;
            }
            if (oldSum > sum)
            {
                maxSum = oldSum;
            }
            else
            {
                maxSum = sum;
            }
        }
        Console.WriteLine("Max sequence sum = {0}", maxSum);
    }
}

