using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Section4
{
    internal class Aula46
    {
        //Membros estáticos - PARTE 1

        static double Pi = 3.14;

        public static void Aula_46()
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double vol = Volume(raio);
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return (4.0 / 3.0) * Pi * Math.Pow(r, 3);
        }
    }
}
