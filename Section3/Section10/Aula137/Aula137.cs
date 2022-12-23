using System;
using Section10.Aula137.Entities;

namespace Section10.Aula137
{
    internal class Aula137
    {
        // Sobreposição, palavras virtual, override e base
        public static void Aula_137()
        {
            Account acc1 = new Account(1001, "Alex", 500.00);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.00, 0.01);

            acc1.Withdraw(10.00);
            acc2.Withdraw(10.00);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
