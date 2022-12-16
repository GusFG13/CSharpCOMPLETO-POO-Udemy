using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Section4
{
    internal class Aula38
    {
        public static void Aula_38()
        {
            // Resolvendo um problema sem orientação a objetos

            // ler as medidas dos triangulos X e Y, mostras as areas e dizer qual dos dois é maior
            // calcular a area de um  triangulo a partir das medidas dos lados
            // formula de Heron
            // area sqrt(p(p-a)(p-b)(p-c)), onde p = (a+b+c)/2
            double xA, xB, xC, yA, yB,yC;
            Console.WriteLine("Entre com as medidas do triângulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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
