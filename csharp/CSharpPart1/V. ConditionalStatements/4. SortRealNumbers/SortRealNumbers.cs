using System;

class SortRealNumbers
{
    static void Main()
    {
        float firstNumber = float.Parse(Console.ReadLine());
        float secondNumber = float.Parse(Console.ReadLine());
        float thirdNumber = float.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("Order of numbers: {0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
        }
        else if (thirdNumber > firstNumber && firstNumber > secondNumber)
        {
            Console.WriteLine("Order of numbers: {0}, {1}, {2}", thirdNumber, firstNumber, secondNumber);
        }
        else if (secondNumber > thirdNumber && thirdNumber > firstNumber)
        {
            Console.WriteLine("Order of numbers: {0}, {1}, {2}", secondNumber, thirdNumber, firstNumber);
        }
        else if (thirdNumber > secondNumber && secondNumber > firstNumber)
        {
            Console.WriteLine("Order of numbers: {0}, {1}, {2}", thirdNumber, secondNumber, firstNumber);
        }
        else if (secondNumber > firstNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("Order of numbers: {0}, {1}, {2}", secondNumber, firstNumber, thirdNumber);
        }
    }
} 

