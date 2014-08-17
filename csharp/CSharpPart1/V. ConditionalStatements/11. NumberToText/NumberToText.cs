using System;

class NumberToText
{

    static void Main()
    {
        string[] onesStr = {"Zero" ,"One", "Two", "Three", "Four", 
                                "Five", "Six", "Seven", "Eight","Nine" };
        string[] specialsStr = {"Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen",
                                    "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] tensStr = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty",
                                "Seventy", "Eighty", "Ninety"};

        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());

        int hundreds = number / 100;
        int tens = (number % 100) / 10;
        int ones = (number % 100) % 10;

        if (number >= 100 && number <= 999)
        {
            if (hundreds != 0 && tens != 0 && tens != 1)
            {
                Console.WriteLine("{0} Hundred and {1} {2}", onesStr[hundreds], tensStr[tens - 2], onesStr[ones]);
            }
            else if (tens == 1)
            {
                Console.WriteLine("{0} Hundred and {1}", onesStr[hundreds], specialsStr[ones]);
            }
            else if (tens == 0 && ones == 0)
            {
                Console.WriteLine("{0} Hundred ", onesStr[hundreds]);
            }
            else if (tens == 0)
            {
                Console.WriteLine("{0} Hundred and {1}", onesStr[hundreds], onesStr[ones]);
            }
            else if (ones == 0)
            {
                Console.WriteLine("{0} Hundred and {1}", onesStr[hundreds], tensStr[tens - 2]);
            }
        }
        if (number >= 20 && number <= 99)
        {
            if (ones == 0)
            {
                Console.WriteLine(tensStr[tens - 2]);
            }
            else
            {
                Console.WriteLine("{0} {1}", tensStr[tens - 2], onesStr[ones]);
            }
        }
        if (number >= 10 && number <= 19)
        {
            Console.WriteLine(specialsStr[ones]);
        }
        if (number >= 0 && number <= 9)
        {
            Console.WriteLine(onesStr[ones]);
        }
    }
}
        

          


