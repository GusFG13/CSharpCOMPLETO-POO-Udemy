using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3
{
    internal class Aula22
    {
        public static void Aula_22()
        {
            //Entrada de dados - parte 1
            /*
            string x;
            int y;
            double z;
            char w;

            x = Console.ReadLine();
            y = int.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            w = char.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);

            Console.ReadLine();
            */
            string frase = Console.ReadLine();
            
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            Console.WriteLine("Você digitou: " + frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


            string a,b,c,s;
            //s = Console.ReadLine();
            //string[] v = s.Split(' ');
            string[] v = Console.ReadLine().Split(' ');
            a = v[0];
            b = v[1];
            c = v[2];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
