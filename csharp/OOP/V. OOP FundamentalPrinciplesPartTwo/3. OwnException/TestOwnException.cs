using System;

class TestOwnException
{
	static void Main()
    {
        PrintNumber();
        Console.WriteLine();
        PrintDateTime();
    }

    private static void PrintNumber()
    {
        const int MinValue = 0;
        const int MaxValue = 100;
        Console.Write("Insert number in the range from {0} to {1}: ", MinValue, MaxValue);
        try
        {
            Console.WriteLine("Inserted number: " + GetNumber(MinValue, MaxValue));
        }
        catch (InvalidRangeException<int> ire)
        {
            Console.WriteLine("InvalidRangeException catched:");
            Console.WriteLine("{0} is not in from the range [{1}:{2}].",
            ire.OutOfRange, ire.Min, ire.Max);
        }
        catch (Exception)
        {
            Console.WriteLine("New exception catched!");
        }
    }

    public static int GetNumber(int min, int max)
    {
        int number = int.Parse(Console.ReadLine());
        if (number < min || number > max)
        {
            throw new InvalidRangeException<int>("Number is not in range.", number, min, max);
        }

        return number;
    }

    private static void PrintDateTime()
    {
        DateTime minDate = new DateTime(1980, 1, 1);
        DateTime maxDate = new DateTime(2013, 12, 31);
        Console.Write("Insert date from {0} to {1}: ", minDate.ToShortDateString(), maxDate.ToShortDateString());
        try
        {
            Console.WriteLine("Inserted datetime: " + GetDateTime(minDate, maxDate));
        }
        catch (InvalidRangeException<DateTime> ire)
        {
            Console.WriteLine("<!> InvalidRangeException catched:");
            Console.WriteLine("DateTime {0} is not in defined range of [{1}:{2}].",
            ire.OutOfRange.ToShortDateString(), ire.Min.ToShortDateString(),
            ire.Max.ToShortDateString());
        }
        catch (Exception e)
        {
            Console.WriteLine("New exception catched!");
        }
    }

    private static DateTime GetDateTime(DateTime min, DateTime max)
    {
        DateTime date = DateTime.Parse(Console.ReadLine());
        if (date < min || date > max)
        {
             throw new InvalidRangeException<DateTime>("Date is not in range.", date, min, max);
        }

        return date;
    }
}

