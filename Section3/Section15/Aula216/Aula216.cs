using Section15.Aula216.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section15.Aula216
{
    internal class Aula216
    {
        public static void Aula_216()
        {
            /*
            string a = "Maria";
            //string b = "Alex";
            string b = "Maria";

            //Console.WriteLine(a.Equals(b));

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            */


            Client a = new Client { Name = "Maria", Email = "maria@gmail.com"};
            //Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
