using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4
{
    internal class Aula39
    {
        //Criando uma classe com três atributos para representar melhor um Triângulo
        public static void Aula_39()
        {
            // ler as medidas dos triangulos X e Y, mostras as areas e dizer qual dos dois é maior
            // calcular a area de um  triangulo a partir das medidas dos lados
            // formula de Heron
            // area sqrt(p(p-a)(p-b)(p-c)), onde p = (a+b+c)/2
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo(); 
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
                Console.WriteLine("Maior área: X");
            else if (areaX < areaY)
                Console.WriteLine("Maior área: Y");
            else
                Console.WriteLine("Áreas iguais");
        }
    }
}
