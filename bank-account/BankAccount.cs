using System;
using System.Collections.Concurrent;

public class BankAccount
{
    private bool AccountIsOpen = false;
    private decimal _Balance;
    private ConcurrentBag<decimal> TransactionHistory;
    public void Open()
    {
        this.AccountIsOpen = true;
        this._Balance = 0;
        this.TransactionHistory = new ConcurrentBag<decimal>();
    }
    public void Close()
    {
        this.AccountIsOpen = false;
    }

    public decimal Balance
    {
        get
        {
            if (this.AccountIsOpen==false) throw new InvalidOperationException("The account is closed!");
            foreach (decimal transaction in TransactionHistory)
            {
                this._Balance += transaction;
            }
            this.TransactionHistory = new ConcurrentBag<decimal>();
            return this._Balance;
        }
    }

    public void UpdateBalance(decimal change)
    {
        this.TransactionHistory.Add(change);
    }
}
