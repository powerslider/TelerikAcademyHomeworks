using System;

class CalculationsWithGenericMethods
{
   
    static void Main(string[] args)
    {
        FindMin(2.1, -5.3, 9, 8.6, 7, 9.63, -4, 8);
        FindMax(2, 5, 9, -8, 7, 9, -4, 8);
        CalculateArithmeticMeanSumProduct(2, 5, 9, -8, 7, 9, -4, 8.3);
    }

    static void FindMin<T>(params T[] elements) where T : IComparable
    {
        T min = elements[0];

        foreach (T number in elements)
        {
            if (min.CompareTo(number) > 0)
            {
                min = number;
            }
        }

        Console.WriteLine("minimum: {0}", min);
    }

    static void FindMax<T>(params T[] elements) where T : IComparable
    {
        T max = elements[0];

        foreach (T number in elements)
        {
            if (max.CompareTo(number) > 0)
            {
                max = number;
            }
        }

        Console.WriteLine("maximum: {0}", max);
    }

    static void CalculateArithmeticMeanSumProduct<T>(params T[] numbers) where T : IConvertible
    {
        decimal sum = 0;
        decimal product = 1;
        int length = numbers.Length;

        if (length > 0)
        {
            for (int i = 0; i < length; i++)
            {
                sum += (decimal) Convert.ChangeType(numbers[i], typeof(decimal));
                product *= (decimal)Convert.ChangeType(numbers[i], typeof(decimal));
            }

            Console.WriteLine("arithmetic mean: {0}", sum / length);
            Console.WriteLine("sum: {0}", sum);
            Console.WriteLine("product: {0}", product);
        }
        else
        {
            Console.WriteLine("The sequence should not be empty");
        }
    }
}


