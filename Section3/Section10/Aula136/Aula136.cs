using System;
using Section10.Aula136.Entities;

namespace Section10.Aula136
{
    internal class Aula136
    {
        // Upcasting e downcasting
        public static void Aula_136()
        {
            Account acc = new Account(1001, "Alex", 0.00);

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.00, 500.00);

            // UPCASTING
            // Classe recebe um objeto de uma sub-classe dela
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.00, 200.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING
            // objeto de uma classe precisa ser convertido antes de ser atribuído a um objeto de uma sub-classe
            // operação insegura - usar apenas se realmente necessário,
            // e testar se variável é realmente compatível com o tipo que você quer converter, ex. abaixo com variável acc5.
            // operador is

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0); // acc4 recebeu acc2, métodos da sub-classe estão disponíveis
                              //acc2.Loan(100.0); // método Loan não está definido na classe de acc2


            // erro pois acc3 é do tipo SavingxAccount, que não é compatível com BusinessAccount
            // o compilador aceita, mas dará erro em tempo de excução do programa
            // um teste de tipo deve ser feito primeiro
            //BusinessAccount acc5 = (BusinessAccount)acc3; //ERRO
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // outra forma de casting
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
