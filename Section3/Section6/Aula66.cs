using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    internal class Aula66
    {
        // Tipos referência e tipos valor
        public static void Aula_66()
        {
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);

        }
    }
}
