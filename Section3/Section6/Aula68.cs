using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    internal class Aula68
    {
        // Nullable
        public static void Aula_68() 
        {
            //double x = null;

            //Nullable<double> x = null;

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value); // lança uma excessão se chamar a partir de um objeto valendo null
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value); // lança uma excessão se chamar a partir de um objeto valendo null
            else
                Console.WriteLine("Y is null");


            // Operador de coalescência nula

            double? w = null;
            double? z = 20.0;

            double a = w ?? 5.0; // se w for null a receberá 5.0
            double b = z ?? 5.0;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
