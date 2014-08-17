using System;

class ReverseDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        ReverseNumber(number);
    }

    static void ReverseNumber(int num)
    {
        while (num > 9)
        {
            Console.Write(num % 10);
            num /= 10;
        }
        Console.Write(num + "\n");
    }
}

