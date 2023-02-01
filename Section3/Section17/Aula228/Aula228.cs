using Section17.Aula228.Entities;
using System;
using System.Collections.Generic;


namespace Section17.Aula228
{
    internal class Aula228
    {
        public static void Aula_228()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //list.Sort(); //usando IComparable e implementação de CompareTo na classe Product

            //list.Sort(CompareProducts); // delegate

            //Comparison<Product> comp = CompareProducts;
            //list.Sort(comp);

            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            //list.Sort(comp);

            //list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            list.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //static int CompareProducts(Product p1, Product p2)
        //{
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}
    }
}
