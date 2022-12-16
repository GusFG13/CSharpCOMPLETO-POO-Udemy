using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Section4
{
    internal class Aula48
    {
        public static void Aula_48()
        {
            /*
             * Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
             * uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
             * que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
             * para ser responsável pelos cálculos.
             * 
             * Exemplo:
             * 
             * Qual é a cotação do dólar? 3.10
             * Quantos dólares você vai comprar? 200.00
             * Valor a ser pago em reais = 657.20
             */

            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais = ");
            Console.WriteLine(ConversorDeMoeda.ConverterDolarParaReal(cotacaoDolar, quantDolar).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
