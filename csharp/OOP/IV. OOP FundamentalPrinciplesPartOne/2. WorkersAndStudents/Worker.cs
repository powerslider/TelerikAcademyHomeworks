using System;

public class Worker : Human
{
    private double weekSalary;
    private double workHoursPerDay;
    private double hourlyWage; 

    public double WeekSalary 
    { 
        get { return this.weekSalary; }
        set 
        {
            if (this.weekSalary < 0)
            {
                throw new ArgumentException("The salary must be a positive number!!!");
            }
            this.weekSalary = value;
        }
    }

    public double WorkHoursPerDay 
    { 
        get { return this.workHoursPerDay; }
        set 
        {
            if (this.workHoursPerDay < 0)
            {
                throw new ArgumentException("The number of work hours must be a positive number!!!");
            }
            this.workHoursPerDay = value;
        }
    }

    public double HourlyWage 
    { 
        get { return this.hourlyWage; }
        set 
        {
            if (this.hourlyWage < 0)
            {
                throw new ArgumentException("The hourly wage must be a positive number!!!");
            }
            this.hourlyWage = value;
        }
    }

    public double MoneyPerHour(double workHours, double payPerHour)
    {
        workHours = this.WorkHoursPerDay;
        payPerHour = this.HourlyWage;
        double result = payPerHour * workHours;

        return result;
    }
}

