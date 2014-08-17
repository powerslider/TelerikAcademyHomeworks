using System;

public class DepositAccount : Account, IDepositable, IWithdrawable
{
    public DepositAccount(CustomerType customer, double balance, 
        double monthlyInterest, int numberOfMonths) 
        : base(customer, balance, monthlyInterest, numberOfMonths)
    { 
    }
    
    public override void CalculateInterest()
    {
        double totalInterest = 0;
        if (this.Balance < 1000)
        {
            totalInterest = 0;
        }
        else
        {
            totalInterest = this.NumberOfMonths * this.MonthlyInterest;
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
    
    public void Withdraw(double withdrawnSum) 
    {
        double newBalance = this.Balance - withdrawnSum;
        this.Balance = newBalance;
        
        Console.WriteLine("You have just withdrawn the sum of {0}lv.", withdrawnSum);
        Console.WriteLine("Your new total balance is {0}lv.", this.Balance);
        Console.WriteLine("----------------------------------------------------------");
    }
}

