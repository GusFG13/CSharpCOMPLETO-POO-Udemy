using System;
using Section10.Aula135.Entities;

namespace Section10.Aula135
{
    internal class Aula135
    {
        // Herança
        public static void Aula_135()
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

            Console.WriteLine(account.Balance);

        }
    }
}
