using System;
using System.Globalization;

namespace Section6
{
    internal class Aula69
    {
        // Vetores - Parte 1
        public static void Aula_69()
        {
            Console.Write("Digite o total de alturas: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite a {i + 1}a. altura: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0; i < n;i++) 
            { 
                soma += vect[i];
            }

            Console.WriteLine($"A altura média é: {(soma / n).ToString("F2", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"A altura média é: {vect.Average().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
