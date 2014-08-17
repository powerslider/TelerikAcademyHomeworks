using System;

class IsLeapYear
{
    static void Main(string[] args)
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        bool isLeap = DateTime.IsLeapYear(year);
        Console.WriteLine("Year {0} is leap: {1}", year, isLeap);
    }
}

