using System;

class BiggerThanNeighbours //not finished yet
{
    static void Main()
    {
        int[] arrayOfInts = { 3, 6, 8, 5, 1, 4, 6, 6, 9, 7, 2, 3, 7, 4 };
        Console.Write("Enter an array element: ");
        int index = int.Parse(Console.ReadLine());
        CompareNumbers(arrayOfInts, index);
    }

    static void CompareNumbers(int[] arr, int position)
    {
        bool isBigger = false;

        if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
        {
            isBigger = true;
            Console.WriteLine("{0}  {1} < {2} > {3}", isBigger, arr[position], arr[position - 1], arr[position + 1]);
        }
        else
        {
            isBigger = false;
            Console.WriteLine("{0}  {1} < {2} > {3}", isBigger, arr[position], arr[position - 1], arr[position + 1]);
        }
        if (position == 0)
        {
            Console.WriteLine("This number doesn't have a neighbour on the left side!");
        }
        if (position == arr.Length - 1)
        {
            Console.WriteLine("This number doesn't have a neighbour on the right side!");
        }
    }

}

