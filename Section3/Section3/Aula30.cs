using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3
{
    internal class Aula30
    {
        //Funções (sintaxe)
        public static void Aula_30()
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);
            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine("Maior = " + n1);
            //} 
            //else if (n2 > n3){
            //    Console.WriteLine("Maior = " + n2);
            //} 
            //else
            //{
            //    Console.WriteLine("Maior = " + n3);
            //}

        }
        static int Maior(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
