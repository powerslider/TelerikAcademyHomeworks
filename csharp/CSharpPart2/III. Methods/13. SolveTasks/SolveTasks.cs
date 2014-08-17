using System;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Press \"1\" to reverse digits of a number");
        Console.WriteLine("Press \"2\" to calculate the average of a sequence of integers");
        Console.WriteLine("Press \"3\" to solve a linear equation\n");
        
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            ReverseDigits(n);
        }
        if (choice == 2)
        {      
            double result = CalculateAverage(ReadSequence());
            Console.Write("The average of the numbers is: {0}", result);
        }
        if (choice == 3)
        {
            Console.Write("a = ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}x = {1}", a, b);
            SolveLinearEquation(a, b); 
        }
    }

    static void ReverseDigits(int num)
    {
        int lastDigit = 0;
        while (num > 0)
        {
            lastDigit = num % 10;
            num /= 10;
            Console.Write(lastDigit);
        }
    }
    
    static double CalculateAverage(double[] numArray)
    {
        double sum = 0;
        double avg = 0;
        for (int i = 0; i < numArray.Length; i++)
        {
            sum += numArray[i];
        }
        avg = sum / numArray.Length;
        
        return avg;
    }
    
    static double[] ReadSequence()
    {
        Console.Write("Enter count of numbers: ");
        int count = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the numbers:");
        double[] numbers = new double[count];

        for (int i = 0; i < count; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        return numbers;
    }

    static void SolveLinearEquation(double aNum, double bNum)
    {
        double result = 0;
        if (aNum != 0)
        {
            result = bNum / aNum;
            Console.Write("x = {0:0.00}\n\n", result);
        }
        else
        {
            Console.WriteLine("No solution");
        }
    }
}

