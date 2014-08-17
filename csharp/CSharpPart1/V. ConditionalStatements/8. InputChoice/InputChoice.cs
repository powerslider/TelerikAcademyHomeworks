using System;

class InputChoice
{
    static void Main()
    {
        Console.Write("Enter \"1\" for integer input, \n\"2\" for real number input \nor \"3\" for string input: " );
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("\nEnter integer value: ");
                int intVar = int.Parse(Console.ReadLine());
                ++intVar;
                Console.WriteLine("End result: {0}\n", intVar);
                break;
            case 2:
                Console.Write("\nEnter real number value: ");
                double doubleVar = double.Parse(Console.ReadLine());
                ++doubleVar;
                Console.WriteLine("End result: {0}\n", doubleVar);
                break;
            case 3:
                Console.Write("\nEnter string: ");
                string stringVar = Console.ReadLine();
                Console.WriteLine("End result: {0}*\n", stringVar);
                break;
            default:
                Console.WriteLine("ERROR");
                break;
        }
    }
}

