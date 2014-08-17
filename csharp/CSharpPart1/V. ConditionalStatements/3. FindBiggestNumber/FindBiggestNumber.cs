using System;

class FindBiggestNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("The biggest number is: {0}\n", firstNumber);
        }
            else if (thirdNumber > firstNumber)
            {
                Console.WriteLine("The biggest number is: {0}\n", thirdNumber);
            }
        else 
        {
            Console.WriteLine("The biggest number is: {0}", secondNumber);
        }
    }
}

