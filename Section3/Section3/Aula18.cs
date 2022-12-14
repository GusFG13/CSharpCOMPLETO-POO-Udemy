using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3
{
    internal class Aula18
    {
        public static void Aula_18()
        {
            /*
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
            Console.WriteLine("A paciente {0} tem {1} anos e seu sexo é: {2}", z, y, w);
            Console.WriteLine($"A paciente {z} tem {y} anos e seu sexo é: {w}");

            Console.ReadLine();
            */
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1.ToString("0.00")}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:0.00)}");

            Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} e genero: {genero}");

            Console.WriteLine($"\nMedida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondando (três casas decimais): {medida:F3}");
            Console.WriteLine($"separador decimal nvariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }

    }
}
