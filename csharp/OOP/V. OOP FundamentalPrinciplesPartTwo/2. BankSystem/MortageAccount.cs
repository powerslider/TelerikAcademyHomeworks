using System;

public class MortageAccount : Account, IDepositable
{
    public MortageAccount(CustomerType customer, double balance,
        double monthlyInterest, int numberOfMonths) 
        : base(customer, balance, monthlyInterest, numberOfMonths)
    {
    }
    
    public override void CalculateInterest()
    {
        double totalInterest = 0;
        if (this.BankCustomer == CustomerType.Individual)
        {
            totalInterest = (this.NumberOfMonths * this.MonthlyInterest) -
               (6 * this.MonthlyInterest);
        }
        if (this.BankCustomer == CustomerType.Company)
        {
            totalInterest = (this.NumberOfMonths * this.MonthlyInterest) -
               12 * (this.MonthlyInterest / 2);
        }
        
        
        Console.WriteLine("The sum of your total interest for the period of {0} months is {1}lv.",
            this.NumberOfMonths, totalInterest);
        Console.WriteLine("----------------------------------------------------------");
    }

    public void Deposit(double depositedSum)
    {
        double newBalance = this.Balance + depositedSum;
        this.Balance = newBalance;
        Console.WriteLine("You have just deposited the sum of {0}lv.", depositedSum);
        Console.WriteLine("Your new total balance is {0}lv.", this.Balance);
        Console.WriteLine("----------------------------------------------------------");
    }
}

