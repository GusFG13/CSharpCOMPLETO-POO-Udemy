using System;
using System.Globalization;
using System.Collections.Generic;
using Section10.Aula146.Entities;

namespace Section10.Aula146
{
    internal class Aula146
    {
        // Exercício proposto (métodos abstratos)
        public static void Aula_146()
        {
            List<Pagador> lista= new List<Pagador>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char tipo = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Anual income: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipo == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(nome, rendaAnual, gastosSaude));
                }
                else if (tipo == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numFuncionarios = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(nome, rendaAnual, numFuncionarios));
                }
            }


            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Pagador pessoa in lista)
            {
                Console.WriteLine(pessoa.ToString());
            }
            double total = 0.0;
            foreach (Pagador pessoa in lista)
            {
                total += pessoa.CalcularImposto();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
