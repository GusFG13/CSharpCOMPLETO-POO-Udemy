using Section15.Aula215.Entities;
using Section15.Aula215.Service;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;

namespace Section15.Aula215
{
    internal class Aula215
    {
        /*
            Uma empresa de consultoria deseja avaliar a performance de produtos,
            funcionários, dentre outras coisas. Um dos cálculos que ela precisa é encontrar
            o maior dentre um conjunto de elementos. Fazer um programa que leia um
            conjunto de N produtos, conforme exemplo, e depois mostre o mais caro deles.

            Criar um serviço de cálculo:
                +---------------------------+
                |     Calculationervice     |
                +---------------------------+
                | + max<T>(list: List<T>):T |
                +---------------------------+

            Exemplo:
            Enter N: 3 
            Computer,890.50
            IPhone X,910.00
            Tablet,550.00
            Max:
            IPhone, 910.00
         */
        public static void Aula_215()
        {
            //List<int> list = new List<int>();
            List<Product> list = new List<Product>();
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //int x = int.Parse(Console.ReadLine());
                //list.Add(x);
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();
            
            //int max = calculationService.Max(list);
            Product max = calculationService.Max(list);

            //Console.WriteLine("Max:");
            Console.WriteLine("Most expensive:");
            Console.WriteLine(max);
        }
    }
}
