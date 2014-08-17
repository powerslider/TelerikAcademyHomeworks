using System;

class FindMaxElementAndSortArray
{
    static void Main()
    {
        int[] arrayOfInts = { 9, 65, 4, 2, 1, 852, 423, 15, 69, 81, 7, 23 };
        int maxNumber = 0;
        
        Console.Write("Sorted array in descending order: ");
        arrayOfInts = SortDescendingArray(arrayOfInts);
        foreach (var element in arrayOfInts)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();
        int startIndex = int.Parse(Console.ReadLine());
        Console.WriteLine("The maximal element is: {0}", GetMax(arrayOfInts, startIndex));

    }
    
    static int[] SortDescendingArray(int[] arr)
    {
        int[] sortedArray = new int[arr.Length];
        for (int i = 0; i < sortedArray.Length; i++)
        {
            sortedArray[i] = GetMax(arr, 0);
        }

        return sortedArray;
    }

    static int GetMax(int[] arr, int index)
    {

        int maxNum = arr[index];
        int maxIndex = 0;
        
        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i] > maxNum )
            {
                maxIndex = i;
                maxNum = arr[i];
            }
        }
        arr[maxIndex] = int.MinValue;
        return maxNum;
    }
}



