namespace OOP.Models;

public class Account
{
    private double _balance;
    protected double Balance
    {
        get
        {
            return this._balance; 
        }
        set
        {
            if (value >= 0)
            {
                this._balance = value;
            }
        }
    }

    public Account(double balance)
    {
        this._balance = balance;
    }

    public virtual bool Withdraw(double amount)
    {
        return true;
    }

    public virtual bool Deposit(double amount)
    {
        return true;
    }

    public virtual void PrintBalance()
    {
        Console.WriteLine($"Account balance is: {this.Balance}");
    }
}