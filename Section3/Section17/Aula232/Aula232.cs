using Section17.Aula228.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Section17.Aula232
{
    internal class Aula232
    {

        //Fazer um programa que, a partir de uma lista de produtos, remova da
        //lista somente aqueles cujo preço mínimo seja 100.
        public static void Aula_232()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.Price >= 100.0);
            list.RemoveAll(ProductTest);

            foreach (Product p in list) 
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
