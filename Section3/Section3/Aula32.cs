using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3
{
    internal class Aula32
    {
        // Estrutura repetitiva enquanto (while)
        public static void Aula_32()
        {
            double x = 0.0;
            double raiz;
            while (x >= 0.0)
            {
                Console.Write("Digite um número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (x >= 0.0)
                {
                    raiz = Math.Sqrt(x);
                    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Número negativo!");
                }
                
            }
           
        } 
    }
}
