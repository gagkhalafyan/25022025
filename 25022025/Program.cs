/*using System;
using System.Numerics;
using System.Runtime.CompilerServices;

public class BankAccount
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(int accountnumber, double balance)
    {
        AccountNumber = accountnumber;
        Balance = balance;
    }

    public override string ToString()
    {
        return $"Account: [{AccountNumber}], Balance: [{Balance}]";
    }

    public override bool Equals(object obj)
    {
        if (obj is BankAccount other)
        {
            return this.AccountNumber == other.AccountNumber;
        }
        return false ;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(AccountNumber, Balance);
    }

    public static BankAccount operator +(BankAccount a, double deposit)
    {
        if (deposit > 0)
        {
            return new BankAccount(a.AccountNumber, a.Balance + deposit);
        }
        else
        {
            return a;
        }
    }

    public static BankAccount operator -(BankAccount a, double withdraw)
    {
        if (withdraw > 0)
        {
            return new BankAccount(a.AccountNumber,a.Balance - withdraw);
        }
        else
        {
            return a;
        }
    }


    public static bool operator >(BankAccount a, BankAccount b)
    {

        return a.Balance > b.Balance;
    }

    public static bool operator <(BankAccount a, BankAccount b)
    {
        return a.Balance < b.Balance;
    }

}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(4564, 1250.5);
        BankAccount account1 = new BankAccount(6523, 2560.4);
        Console.WriteLine(account.ToString());
        Console.WriteLine(account1.ToString());
        Console.WriteLine(account.Equals(account1));
        Console.WriteLine(account.GetHashCode());
        Console.WriteLine(account + 8000);
        Console.WriteLine(account > account1);
    }
}*/




