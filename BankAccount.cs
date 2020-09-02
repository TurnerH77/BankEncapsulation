using System;
using System.Collections.Generic;
using System.Text;
using BankEncapsulation;

public class BankAccount
{
	private double _balance = 0;

    public void Deposit(double ammount)
    {
        _balance += ammount;
    }

    public double Getbalance()
    {
        return _balance;
    }
}
