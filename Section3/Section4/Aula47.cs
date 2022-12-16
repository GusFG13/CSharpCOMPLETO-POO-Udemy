using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4
{
    internal class Aula47
    {
        //Membros estáticos - PARTE 2

        public static void Aula_47()
        {

            //Calculadora calc = new Calculadora(); // se método não for static tem que instanciar (new)
            //se for static, chama apenas pela Classe

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double circ = calc.Circunferencia(raio); //método não static instanciado
            double circ = Calculadora.Circunferencia(raio); //Método static, chama diretamente pela Classe

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            //double vol = calc.Volume(raio); //método não static instanciado
            double vol = Calculadora.Volume(raio); //Método static, chama diretamente pela Classe

            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
