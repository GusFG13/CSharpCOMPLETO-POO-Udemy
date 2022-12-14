using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3
{
    internal class Aula23
    {
        public static void Aula_23()
        {
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Você digitou: " + n1);

            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine(ch);

            ////double n2 = double.Parse(Console.ReadLine()); //entrada precisa ser com vírgula
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //entrada precisa ser com ponto
            //Console.WriteLine(n2);
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            string[] vet = Console.ReadLine().Split(' ');
            // Maria F 20 1.68
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            float altura = float.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
