using System;

class Workdays
{
    static int workdaysCount = 0;

    static DateTime[] holidays =
    {
        new DateTime(2012, 3, 3),
        new DateTime(2012, 5, 6),
    };

    static void Main(string[] args)
    {
        Console.Write("Enter end date(yyyy/mm/dd): ");
        string date = Console.ReadLine();
        DateTime endDate = DateTime.Parse(date);
        WorkDaysCounter(endDate);
        Console.WriteLine("Workdays between {0} and {1}: {2}",
            DateTime.Now.Date, endDate, workdaysCount);
    }

    static void WorkDaysCounter(DateTime endDate)
    {
        for (DateTime currentDate = DateTime.Now.Date; currentDate <= endDate;
                currentDate = currentDate.AddDays(1))
        {
            if (currentDate.DayOfWeek != DayOfWeek.Saturday &&
                currentDate.DayOfWeek != DayOfWeek.Sunday &&
                IsNotHoliday(currentDate))
            {
                workdaysCount++;                    
            }
        }
    }

    static bool IsNotHoliday(DateTime currentDate)
    {
        foreach (DateTime date in holidays)
        {
            if (currentDate == date)
            {
                return false;
            }
        }
        return true;
    }
}
