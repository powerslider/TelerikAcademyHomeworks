using System;

public enum CustomerType
{
    Individual,
    Company
};

public abstract class Customer
{
    public CustomerType BankCustomer { get; set; }
}

