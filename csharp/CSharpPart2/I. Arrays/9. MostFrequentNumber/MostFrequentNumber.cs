using System;

class MostFrequentNumber
{
    static void Main()
    {
        Console.Write("Number of array elements: ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        //int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 4, 4, 1, 2, 9, 3 };
        Array.Sort(arr);

        int count = 1;
        int maxCount = 0;
        int mostFreqNum = 0;
        
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] == arr[i])
            {
                count++;
                if (maxCount < count)
                {
                     maxCount = count;
                     mostFreqNum = arr[i];                  
                }
            }
            else
            {
                count = 1;
            }
        }
        Console.WriteLine("The most frequent number is {0} ({1} times).", mostFreqNum, maxCount);
    }
}

