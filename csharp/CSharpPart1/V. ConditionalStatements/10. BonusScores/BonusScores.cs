using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Input digit: ");
        int digit = int.Parse(Console.ReadLine());
        byte k = 0;

        if (digit >= 0 && digit <= 3)
            k = 1;
        if (digit >= 4 && digit <= 6)
            k = 2;
        if (digit >= 7 && digit <= 9)
            k = 3;

        switch (k)
        {
            case 1:
                digit *= 10;
                Console.WriteLine("\nBonus Score x10: {0}\n", digit);
                break;
            case 2:
                digit *= 100;
                Console.WriteLine("\nBonus Score x100: {0}\n", digit);
                break;
            case 3:
                digit *= 1000;
                Console.WriteLine("\nBonus Score x1000: {0}\n", digit);
                break;
            default:
                Console.WriteLine("\nERROR\n");
                break;
        }

    }
}
