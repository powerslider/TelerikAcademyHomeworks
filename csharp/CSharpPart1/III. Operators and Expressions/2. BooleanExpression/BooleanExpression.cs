using System;

class BooleanExpression
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        string x = Console.ReadLine();
        int xNum = int.Parse(x);
        
        bool result1 = (xNum % 5 == 0);
        bool result2 = (xNum % 7 == 0);
        Console.WriteLine(result1 && result2 ? xNum + "/5" + "=" + (xNum/5) + "\n" + xNum + "/7" + "=" + (xNum/7) : "The number cannot be accurately divided!");
    }
}

