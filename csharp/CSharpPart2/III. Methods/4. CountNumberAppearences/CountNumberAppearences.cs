using System;

class CountNumberAppearences
{
    static void Main()
    {
        int[] arrayOfInts = { 3, 6, 8, 5, 1, 4, 6, 6, 9, 7, 2, 3, 7, 4 };

        Console.Write("Enter an array element: ");
        int number = int.Parse(Console.ReadLine());
        CountFrequency(number, arrayOfInts);
    }

    static void CountFrequency(int num, int[] arr)
    {
        int numCount = 0;

        foreach (var element in arr)
        {
            if (element == num)
            {
                numCount++;
            }
        }
        Console.WriteLine(numCount);
    }
}

