using System;

class PrintBoolVariable
{
    static void Main()
    {
        int a = 1;
        int b = 1;
        bool isFemale = (a > b);   // this equals "False"

        Console.WriteLine("Am I a woman? - {0}", isFemale);

        if (isFemale)
        {
            Console.WriteLine("I'm a woman!!!\n");
        }
        else 
        {
            Console.WriteLine("I'm a man!!!\n");
        }
    }
}
