using System;

class AddingBigNumbers
{
    static void Main(string[] args)
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();
        int[] num1 = new int[10000];
        int[] num2 = new int[10000];
        int maxLength = Math.Max(firstNumber.Length, secondNumber.Length);

        for (int i = firstNumber.Length - 1, j = 0; i >= 0; i--, j++)
        {
            num1[j] = firstNumber[i] - '0';
        }

        for (int i = secondNumber.Length - 1, j = 0; i >= 0; i--, j++)
        {
            num2[j] = secondNumber[i] - '0';
        }

        AddBigNumbers(num1, num2, maxLength);

        Console.WriteLine();
    }

    private static void AddBigNumbers(int[] num1, int[] num2, int length)
    {
        int[] result = new int[10001];
        int carry = 0;

        for (int i = 0; i < length; i++)
        {
            result[i] = (num1[i] + num2[i] + carry) % 10;
            if (num1[i] + num2[i] + carry > 9)
            {
                carry = 1;
            }
            else
            {
                carry = 0;
            }
        }

        if (num1[length - 1] + num2[length - 1] > 9)
        {
            result[length] = 1;
            length++;
        }

        for (int i = length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
    }
}

