using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3
{
    internal class Aula26
    {
        public static void Aula_26()
        {
            //Operadores lógicos
            //precedência ! > && > ||
            //Console.WriteLine(2 > 3 || 4 != 5);
            //Console.WriteLine(!(2 > 3) && 4 != 5);

            //bool c1 = 4 != 5;
            //bool c1 = 2 > 3 && 4 != 5;
            bool c1 = 2 > 3 || 4 != 5;
            bool c2 = !(2 > 3) && 4 != 5;
            Console.WriteLine(c1);
            Console.WriteLine(c2);


            bool c3 = 10 < 5;
            bool c4 = c1 || c2 && c3;

            Console.WriteLine(c3);
            Console.WriteLine(c4);
        }
    }
}
