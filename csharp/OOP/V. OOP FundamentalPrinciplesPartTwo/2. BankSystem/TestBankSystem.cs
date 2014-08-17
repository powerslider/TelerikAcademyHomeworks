using System;

class TestBankSystem
{
    static void Main()
    {
        Console.WriteLine("----------Loan Account(Company)----------\n");
        LoanAccount accountOne = new LoanAccount(CustomerType.Company, 50000, 500, 24);
        accountOne.CalculateInterest();
        accountOne.Deposit(500);

        Console.WriteLine("\n\n----------Loan Account(Individual)----------\n");
        LoanAccount accountTwo = new LoanAccount(CustomerType.Individual, 50000, 500, 24);
        accountTwo.CalculateInterest();
        accountTwo.Deposit(500);

        Console.WriteLine("\n\n----------Mortage Account(Company)----------\n");
        MortageAccount accountThree = new MortageAccount(CustomerType.Company, 100000, 1000, 36);
        accountThree.CalculateInterest();
        accountThree.Deposit(10000);

        Console.WriteLine("\n\n----------Mortage Account(Individual)----------\n");
        MortageAccount accountFour = new MortageAccount(CustomerType.Individual, 100000, 1000, 36);
        accountFour.CalculateInterest();
        accountFour.Deposit(10000);

        Console.WriteLine("\n\n----------Deposit Account(Company)----------\n");
        DepositAccount accountFive = new DepositAccount(CustomerType.Company, 500000, 5000, 24);
        accountFive.CalculateInterest();
        accountFive.Deposit(100000);
        accountFive.Withdraw(200000);

        Console.WriteLine("\n\n----------Deposit Account(Individual)----------\n");
        DepositAccount accountSix = new DepositAccount(CustomerType.Individual, 500000, 5000, 24);
        accountSix.CalculateInterest();
        accountSix.Deposit(100000);
        accountSix.Withdraw(200000);

        Console.WriteLine("\n\n----------Deposit Account(Balance under 1000)----------\n");
        DepositAccount accountSeven = new DepositAccount(CustomerType.Individual, 500, 50, 6);
        accountSeven.CalculateInterest();
        accountSeven.Deposit(50);
        accountSeven.Withdraw(150);

        Console.WriteLine("\n\n\n");
    }
}

