using System;

class ThirdDigitCheck
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string a = Console.ReadLine();
        int aNum = int.Parse(a);
        int bNum = aNum / 100;
        int cNum = bNum % 10;
        Console.WriteLine();

        bool check = (cNum == 7);
        Console.WriteLine(check ? "\n7 is the third digit of the number " + aNum + " (right-to-left)!\n"
            : "\n7 is not the third digit of the number " + aNum + " (right-to-left)!\n");
    }
}

