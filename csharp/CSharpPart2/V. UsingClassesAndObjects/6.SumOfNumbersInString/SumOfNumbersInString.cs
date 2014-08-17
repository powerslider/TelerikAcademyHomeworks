using System;

class SumOfNumbersInString
{
    static void Main(string[] args)
    {
        string sequence = "43 68 9 23 318";
        string[] numbers = sequence.Split(' ');
        int sum = 0;

        foreach (string number in numbers)
        {
            sum += int.Parse(number);   
        }

        Console.WriteLine(sum);
    }
}

