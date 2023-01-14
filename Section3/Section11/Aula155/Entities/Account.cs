using System;
using System.Globalization;
using Section11.Aula155.Entities.Exceptions;

namespace Section11.Aula155.Entities
{
    /*
        +----------------------------------+
        |              Account             |
        +----------------------------------+
        | - number: integer                |
        | - holder: string                 |
        | - balance: double                |
        | - withdrawLimit: double          |
        +----------------------------------+
        | + deposit(amount: double): void  |
        | + withdraw(amount: double): void |
        +----------------------------------+
    */
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"New Balance: {Balance.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (Balance < amount) 
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
            Console.WriteLine($"New Balance: {Balance.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
