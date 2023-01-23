using Section15.Aula219.Entities;
using System;
using System.Collections.Generic;

namespace Section15.Aula219
{
    internal class Aula219
    {
        public static void Aula_219()
        {
            //HashSet<string> set = new HashSet<string>();
            //set.Add("Maria");
            //set.Add("Alex");
            //Console.WriteLine(set.Contains("Maria"));

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Notebook", 1200.00));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.00);
            //retornaria falso se os overrides de GetHashCode e Equals não tivessem sido implementados
            //porque iria comparar apenas o endereço de memória dos objetos e não o valores (no caso de tipos referência)
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);
            //retornaria verdadeiro mesmo sem os overrides de GetHashCode e Equals implementados
            //pois compara o conteúdo (no caso de tipos valor)
            Console.WriteLine(b.Contains(p));

        }
    }
}
