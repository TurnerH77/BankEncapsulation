using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount();

            Console.WriteLine("How much would you like to deposit?: ");
            double ammountToDeposit = Convert.ToInt32(Console.ReadLine());

            bank.Deposit(ammountToDeposit);
            double userBalance = bank.Getbalance();

            Console.WriteLine($"Your Balance is : {userBalance}");
        }
    }
}
