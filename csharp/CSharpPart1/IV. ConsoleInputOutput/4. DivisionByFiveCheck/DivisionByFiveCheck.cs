using System;

class DivisionByFiveCheck
{
    static void Main()
    {
        Console.Write("i = ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("j = ");
        int j = int.Parse(Console.ReadLine());
        int count = 0;

        for (int k = i; k <=j ; k++)
        {
            if (k % 5 == 0) 
            {
                count++; 
            }
        }
        Console.WriteLine(count);
    }
}

