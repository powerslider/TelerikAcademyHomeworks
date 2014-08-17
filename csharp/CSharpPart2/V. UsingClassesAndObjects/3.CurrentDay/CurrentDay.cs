using System;

class CurrentDay
{
    static void Main()
    {
        DateTime today = new DateTime();
        Console.WriteLine("Today is " + today.DayOfWeek);
    }
}

