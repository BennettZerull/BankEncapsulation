using System.Dynamic;

namespace BankEncapsulation;

public class BankAccount
{
    private double _balance = 0;

    public void Deposit(double depositAmount)
    {
        _balance += depositAmount;
    }

    public void Withdraw(double withdrawAmount)
    {
        _balance -= withdrawAmount;
    }

    public double GetBalance()
    {
        return _balance;
    }
}    