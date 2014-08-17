using System;

class SortAndBinarySearch
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        int index = Array.BinarySearch(array, k);
        if (index > 0)
        {
            Console.WriteLine("the largest number <= k is: " + k);
        }
        else
        {
            index = ~index;
            if (index >= n)
            {
                Console.WriteLine("the largest number <= k is: " + array[n - 1]);                    
            }
            else
	        {
                if (index > 0)
                {
                    Console.WriteLine("the largest number <= k is: " + array[index - 1]);
                }
                else
                {
                    Console.WriteLine("k is smaller than the smallest number in the array");
                }
	        }
        }
    }
}

