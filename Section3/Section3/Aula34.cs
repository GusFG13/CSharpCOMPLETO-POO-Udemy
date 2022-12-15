using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3
{
    internal class Aula34
    {
        public static void Aula_34()
        {
            // Estrutura repetitiva para (for)
            Console.Write("Quantos números inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Valor #{i}: ");
                soma += int.Parse(Console.ReadLine());
            }
            Console.Write($"Soma = {soma}");
        }
    }
}
