using System;
using System.Collections.Generic;
using System.Globalization;
using Section17.Aula233.Entities;

namespace Section17.Aula233
{
    class Aula233
    {
        public static void Aula_233()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.ForEach(UpdadePrice);

            //Action<Product> act = UpdadePrice;

            //expressão lambda
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };

            //list.ForEach(act);

            //expressão lambda in line
            list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdadePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
