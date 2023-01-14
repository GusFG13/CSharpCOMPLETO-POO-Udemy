using System;
using System.Globalization;
using Section11.Aula155.Entities;
using Section11.Aula155.Entities.Exceptions;

namespace Section11.Aula155
{
    internal class Aula155
    {
        /*
            Fazer um programa para ler os dados de uma conta bancária e depois realizar um
            saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
            ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
            saque da conta. Implemente a conta bancária conforme projeto abaixo:

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
        public static void Aula_155()
        {

            /*

Number: 8021
Holder: Bob Brown
Initial balance: 500.00
Withdraw limit: 300.00
Enter amount for withdraw: 800.00

            */
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                Account acc = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Withdraw(withdrawAmount);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e) 
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
