﻿using System;
using System.Globalization;
using System.Collections.Generic;
using Section10.Aula143.Entities;

namespace Section10.Aula143
{
    internal class Aula143
    {
        // Classes abstratas
        public static void Aula_143()
        {
            // classe abstrata não pode ser instanciada
            //Account acc1 = new Account(1001, "Alex", 500.00);
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
            list.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.00, 500.00));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
