using System;

public enum AccountType
{
    Deposit,
    Loan,
    Mortage
};

public class Account : Customer
{
    private AccountType account;
    private double balance;
    private double monthlyInterest;
    private int numberOfMonths;
    
    

    public AccountType BankAccount { get; set; }
    public double Balance { get; set; }
    public double MonthlyInterest
    {
        get 
        {
            if (this.monthlyInterest < 0)
            {
                throw new ArgumentException("Interest rate must be positive !!!");
            }
            return this.monthlyInterest;
        }
        set
        {
            if (this.monthlyInterest < 0)
            {
                throw new ArgumentException("Interest rate must be positive !!!");
            }
            this.monthlyInterest = value;
        }
    }

    public int NumberOfMonths
    {
        get
        {
            if (this.numberOfMonths < 0)
            {
                throw new ArgumentException("Number of months must be positive !!!");
            }
            return this.numberOfMonths;
        }
        set
        {
            if (this.numberOfMonths < 0)
            {
                throw new ArgumentException("Number of months must be positive !!!");
            }
            this.numberOfMonths = value;
        }
    }
    
    public Account(CustomerType customer, double balance, 
        double monthlyInterest, int numberOfMonths, AccountType account)
    {
        this.BankCustomer = customer;        
        this.Balance = balance;
        this.MonthlyInterest = monthlyInterest;
        this.NumberOfMonths = numberOfMonths;
        this.BankAccount = account;
    }

    public Account(CustomerType customer, double balance, double monthlyInterest, int numberOfMonths)
        : this(customer, balance, monthlyInterest, numberOfMonths, new AccountType())
    {
    }

    public virtual void CalculateInterest()
    {
        double totalInterest = this.NumberOfMonths * this.MonthlyInterest;
        Console.WriteLine("The sum of your total interest for the period of {0} months is {1}lv.",
            this.NumberOfMonths, totalInterest);
    }
}

