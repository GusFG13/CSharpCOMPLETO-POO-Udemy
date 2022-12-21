using System;
using System.Globalization;

namespace Section7
{
    internal class Aula87
    {
        // Sintaxe alternativa - expressão condicional ternária
        public static void Aula_87()
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;

            //if (preco < 20.0)
            //{
            //    desconto = preco * 0.1;
            //}
            //else
            //{
            //    desconto = preco * 0.05;
            //}

            desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
