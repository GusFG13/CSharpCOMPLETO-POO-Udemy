﻿namespace Section10.Aula143.Entities
{
    abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            // 5.00 taxa por saque
            Balance -= (amount + 5.00);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
