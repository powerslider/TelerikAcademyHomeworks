using System;

class CalculationsWithInts
{
    static void Main()
    {
        GetMin(2, 1, 5, 4, 7, 9, 10, 8, 6, 3);
        GetMax(2, 1, 5, 4, 7, 9, 10, 8, 6, 3);
        CalculateAverage(2, 1, 5, 4, 7, 9, 10, 8, 6, 3);
        CalculateSum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        CalculateProduct(2, 1, 5, 4, 7, 9, 10, 8, 6, 3);
    }   
    static void GetMin(params int[] numbers)
    {
        int min = numbers[0];
        foreach (var number in numbers)
	    {
		    if (min > number)
            {
                min = number;
            }
	    }

        Console.WriteLine("The smallest number is: {0}", min);
    }

    static void GetMax(params int[] numbers)
    {
        int max = numbers[0];
        foreach (var number in numbers)
        {
            if (max < number)
            {
                max = number;
            }
        }

        Console.WriteLine("The biggest number is: {0}", max);
    }

    static void CalculateAverage(params int[] numArray)
    {
        double sum = 0;
        double avg = 0;
        for (int i = 0; i < numArray.Length; i++)
        {
            sum += numArray[i];
        }
        avg = sum / numArray.Length;

        Console.WriteLine("The average of the integers is: {0}", avg);
    }
    
    static void CalculateSum(params int[] numArray)
    {
        double sum = 0;
        for (int i = 0; i < numArray.Length; i++)
        {
            sum += numArray[i];
        }
      
        Console.WriteLine("The sum of the integers is: {0}", sum);
    }

    static void CalculateProduct(params int[] numArray)
    {
        double product = numArray[0];
        for (int i = 1; i < numArray.Length; i++)
        {
            product *= numArray[i];
        }

        Console.WriteLine("The product of the integers is: {0}\n", product);
    }
}

