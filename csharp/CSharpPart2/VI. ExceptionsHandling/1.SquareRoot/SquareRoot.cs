using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new FormatException();
            }
            Console.WriteLine(Math.Sqrt(number));

        }
        catch (FormatException fe)
        {
            Console.WriteLine("Invalid number"); ;
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}

