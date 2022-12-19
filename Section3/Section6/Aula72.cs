using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    internal class Aula72
    {
        // Modificador de parâmetros: params
        public static void Aula_72()
        {
            int s1 = Calculator.Sum(1, 3, 5);
            int s2 = Calculator.Sum(1, 9, 4, 6, 8);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
