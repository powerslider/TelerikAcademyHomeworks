using System;

class FindSequenceOfGivenSum
{
    static void Main()
    {
        Console.Write("Number of array elements: ");
        int N = int.Parse(Console.ReadLine());

        //int[] arr = { 4, 3, 1, 4, 2, 5, 8 }; // if S = 11
        int[] arr = new int[N];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nTarget sum:\nS = ");
        int S = int.Parse(Console.ReadLine());

        int sum = 0;
        int startElement = 0;
        int endElement = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            endElement = i;
            if (sum > S)
            {
                sum = 0;
                startElement = endElement - 1;
                i -= 1;
            }
            if (sum == S)
            {
                for (int j = startElement + 1; j <= endElement; j++)
                {
                    Console.Write(arr[j] + " ");
                }
            }
        }
    }
}

