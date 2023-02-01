using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using Section17.Aula241.Entities;

namespace Section17.Aula241
{
    /*
        Fazer um programa para ler um conjunto de produtos a partir de um
        arquivo em formato .csv (suponha que exista pelo menos um produto).
        Em seguida mostrar o preço médio dos produtos. Depois, mostrar os
        nomes, em ordem decrescente, dos produtos que possuem preço
        inferior ao preço médio.

        Input file:
            Tv,900.00
            Mouse,50.00
            Tablet,350.50
            HD Case,80.90
            Computer,850.00
            Monitor,290.00

        Execution:
            Enter full file path: c:\temp\in.txt
            Average price: 420.23
            Tablet
            Mouse
            Monitor
            HD Case
     */
    internal class Aula241
    {
        public static void Aula_241()
        {
            Console.Write("Enter full file path:");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();   

            using (StreamReader sr = File.OpenText(path)) 
            {
                while(!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

            Console.WriteLine("Average price: " + avg.ToString("F2",CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

        }


    }
}
