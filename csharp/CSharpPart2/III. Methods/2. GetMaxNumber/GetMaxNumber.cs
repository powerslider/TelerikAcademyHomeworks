using System;

class GetMaxNumber
{
    static void Main()
    {
        Console.WriteLine("Enter Numbers:");
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        int biggestNum = 0;

        int maxOne = GetMax(firstNum, secondNum);
        int maxTwo = GetMax(maxOne, thirdNum);

        if (maxOne > thirdNum)
        {
            biggestNum = maxOne;
        }
        else
        {
            biggestNum = maxTwo;
        }
        Console.WriteLine("The biggest number is: {0}\n", biggestNum);
    }

    static int GetMax(int a, int b)
    {
        int maxNumber = 0;
        if (a > b)
        {
            maxNumber = a;
        }
        else
        {
            maxNumber = b;
        }

        return maxNumber;
    }
}
