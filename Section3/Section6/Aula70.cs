using System;
using System.Globalization;

namespace Section6
{
    internal class Aula70
    {
        // Vetores - PARTE 2
        public static void Aula_70()
        {
            Console.Write("Digite o total de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i =0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double soma = 0.0;
            for (int i =0; i < n; i++)
            {
                soma += vect[i].Price;
            }

            double avg = soma / n;

            Console.WriteLine("Preço médio = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
