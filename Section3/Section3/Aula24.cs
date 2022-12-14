using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Section3
{
    internal class Aula24
    {
        //Exercícios propostos
        public static void Ex1()
        {
            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            //mensagem explicativa, conforme exemplos.
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA = {x + y}");
        }
        public static void Ex2()
        {
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            //casas decimais conforme exemplos.
            //Fórmula da área: area = π.raio2
            //Considere o valor de π = 3.14159
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double area = pi * raio * raio;
            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
        }
        public static void Ex3()
        {
            //Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto
            //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int diferenca = (A * B - C * D);
            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
        public static void Ex4()
        {
            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            //hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            //decimais.

            int num = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double salarioPorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine($"NUMBER = {num}");
            Console.WriteLine($"SALARY = U$ {(horas * salarioPorHora).ToString("F2", CultureInfo.InvariantCulture)}");

        }
        public static void Ex5()
        {
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.
            string[] peca1 = Console.ReadLine().Split(' ');
            string[] peca2 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(peca1[0]);
            int cod2 = int.Parse(peca2[0]);
            int quant1 = int.Parse(peca1[1]);
            int quant2 = int.Parse(peca2[1]);
            double valUn1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);
            double valUn2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);
            double valTotalPeca1 = quant1 * valUn1;
            double valTotalPeca2 = quant2 * valUn2;
            Console.Write("VALOR A PAGAR: R$ ");
            Console.WriteLine((valTotalPeca1 + valTotalPeca2).ToString("F2",CultureInfo.InvariantCulture));

        }
        public static void Ex6()
        {
            //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            //mostre:
            //a) a área do triângulo retângulo que tem A por base e C por altura.
            //b) a área do círculo de raio C. (pi = 3.14159)
            //c) a área do trapézio que tem A e B por bases e C por altura.
            //d) a área do quadrado que tem lado B.
            //e) a área do retângulo que tem lados A e B.
            string[] entrada = Console.ReadLine().Split(' ');
            double A = double.Parse(entrada[0],CultureInfo.InvariantCulture);
            double B = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            double C = double.Parse(entrada[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double areaTriangulo = (A * C) / 2;
            double areaCirculo = pi * C * C;
            double areaTrapezio = ((A + B)/2) * C;
            double areaQuadrado = B * B;
            double areaRetangulo = A * B;
            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
