using System;
using System.Collections.Generic;
using System.Linq;
using Section17.Aula234.Entiites;


namespace Section17.Aula234
{
    class Aula234
    {
        public static void Aula_234()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //List<string> result = list.Select(NameUpper).ToList();
            //List<string> result = list.Select(NameUpper).ToList();

            //Func<Product, string> func = NameUpper;
            //List<string> result = list.Select(func).ToList();

            // Com expressão lambda
            //Func<Product, string> func = p => p.Name.ToUpper();
            //List<string> result = list.Select(func).ToList();

            // Com expressão lambda in-line
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        //static string NameUpper(Product p)
        //{
        //    return p.Name.ToUpper();
        //}
    }
}
