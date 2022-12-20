using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    internal class Aula73
    {
        // Modificadores de parãmetros ref e out
        public static void Aula_73()
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int b = 15;
            int triplo;
            Calculator.Triple_2(b, out triplo);
            Console.WriteLine(triplo);
        }
    }
}
