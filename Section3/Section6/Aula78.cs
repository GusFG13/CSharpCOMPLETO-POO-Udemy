using System;
using System.Collections.Generic;
using System.Globalization;

namespace Section6
{
    internal class Aula78
    {
        // exercício de fixação (listas)

        /*
         * Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
         * N funcionários. Não deve haver repetição de id.
         * Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
         * Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
         * mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
         * conforme exemplos.
         * Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
         * ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
         * aumento por porcentagem dada.
         * 
         * Exemplo 1:
         * 
         * How many employees will be registered? 3
         * Emplyoee #1:
         * Id: 333
         * Name: Maria Brown
         * Salary: 4000.00
         * 
         * Emplyoee #2:
         * Id: 536
         * Name: Alex Grey
         * Salary: 3000.00
         * 
         * Emplyoee #3:
         * Id: 772
         * Name: Bob Green
         * Salary: 5000.00
         * 
         * Enter the employee id that will have salary increase : 536
         * Enter the percentage: 10.0
         * 
         * Updated list of employees:
         * 333, Maria Brown, 4000.00
         * 536, Alex Grey, 3300.00
         * 772, Bob Green, 5000.00
         * 
         * Exemplo 2:
         * 
         * How many employees will be registered? 2
         * Emplyoee #1:
         * Id: 333
         * Name: Maria Brown
         * Salary: 4000.00
         * 
         * Emplyoee #2:
         * Id: 536
         * Name: Alex Grey
         * Salary: 3000.00
         *
         * Enter the employee id that will have salary increase: 776
         * This id does not exist!
         *
         * Updated list of employees:
         * 333, Maria Brown, 4000.00
         * 536, Alex Grey, 3000.00
         */

        public static void Aula_78()
        {
            List<FuncionarioAula78> listaFunc = new List<FuncionarioAula78>();
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            int id;
            int indice;
            string nome;
            double salario;
            double pctAumento;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Emplyoee #{i + 1}:");
                Console.Write($"Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write($"Name: ");
                nome = Console.ReadLine();
                Console.Write($"Salary: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listaFunc.Add(new FuncionarioAula78 { Nome = nome, Id = id, Salario = salario});
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());
            indice = listaFunc.FindIndex(x => x.Id == id);
            if ( indice != -1) 
            {
                Console.Write("Enter the percentage: ");
                pctAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaFunc[indice].AumentarSalario(pctAumento);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (FuncionarioAula78 f in listaFunc)
            {
                Console.WriteLine(f.ToString());
            }
        }
    }
}
