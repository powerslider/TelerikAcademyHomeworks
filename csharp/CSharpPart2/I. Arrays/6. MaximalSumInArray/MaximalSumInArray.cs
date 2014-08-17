using System;

class MaximalSumInArray
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

        int[] arr = { 3, 2, 3, 4, 2, 2, 4 };
        
        Console.Write("\nNumber of subset elements: ");
        int K = int.Parse(Console.ReadLine());

        int sum = 0;
      
        //Array.Sort(arr);
   
        //for (int i = arr.Length - K; i < arr.Length; i++)
        //{
        //    sum += arr[i];
        //}

        //Array.Sort(arr);
        int maxSum = 0;
        int counter = 0;
        for (int i = 1; i <= arr.Length; i++)
        {
            sum += arr[i];
            counter++;
            if (counter == K)
            {
                if (maxSum < sum)
                {
                    maxSum = sum;
                }
                counter = 0;
                sum = 0;
                i = i - 1;
            }
        }
        Console.WriteLine("\nMax sequence sum = {0}\n", sum);
    }
}

