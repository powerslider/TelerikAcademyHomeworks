using System;

class SelectionSort
{
    static void Main()
    {
        int[] arr = { 5, 1, 9, 3, 2, 4, 6, 8, 7, 0 };
        //Console.Write("Number of array elements: ");
        //int N = int.Parse(Console.ReadLine());

        //int[] arr = new int[N];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
        
        int min;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[min] > arr[j])
                {
                    min = j;
                }                      
                if (min != i)
                {
                    int k = arr[i];
                    arr[i] = arr[min];
                    arr[min] = k;
                }
            }             
        }
        foreach (var element in arr)
	    {
		    Console.Write(element + " ");
	    }
    }
}

