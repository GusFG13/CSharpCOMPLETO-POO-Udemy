using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Section3
{
    internal class Aula35
    {
        // Exercícios propostos sobre Estrutura Repetitiva FOR
        public static void Ex1()
        {
            // Leia um valor inteiro X(1 <= X <= 1000).Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            // X, se for o caso.
            Console.Write("Digite um número inteiro, entre 1 e 1000: ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 1000)
            {
                for (int i = 1; i <= num; i++) 
                {
                    if (i % 2 !=0)
                        Console.WriteLine(i);
                }
            }
        }

        public static void Ex2()
        {
            //Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
            Console.Write("Digite quantos números inteiros você irá digitar: ");
            int N = int.Parse(Console.ReadLine());
            int nIn = 0;
            int nOut = 0;
            int num;
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Valor #{i}: ");
                num = int.Parse(Console.ReadLine());
                if (num >= 10 && num <= 20)
                    nIn++;
                else
                    nOut++;
            }
            Console.WriteLine(nIn + " in");
            Console.WriteLine(nOut + " out");

        }
        public static void Ex3()
        {
            // Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            // de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
            // conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            // peso 5.
            Console.Write("Digite o número de casos teste você irá entrar: ");
            int N = int.Parse(Console.ReadLine());
            string[] entradas;
            double n1, n2, n3;
            double media;
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Caso #{i}: ");
                entradas = Console.ReadLine().Split();
                n1 = double.Parse(entradas[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(entradas[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(entradas[2], CultureInfo.InvariantCulture);
                media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        public static void Ex4()
        {
            // Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            // segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
            Console.Write("Digite o número de pares de inteiros você irá entrar: ");
            int N = int.Parse(Console.ReadLine());
            string[] entradas;
            int n1, n2;
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Par #{i}: ");
                entradas = Console.ReadLine().Split();
                n1 = int.Parse(entradas[0]);
                n2 = int.Parse(entradas[1]);
                if (n2 == 0)
                    Console.WriteLine("divisao impossivel");
                else
                {
                    Console.WriteLine(((double)n1 / n2).ToString("F1", CultureInfo.InvariantCulture));
                }          
            }
        }

        public static void Ex5()
        {
            Console.Write("Digite um número inteiro para calcular o fatorial: ");
            int N = int.Parse(Console.ReadLine());
            long fatorial = 1;
            for (int i = N; i > 1; i--)
            {
                fatorial *= i;
            }
            Console.WriteLine(fatorial);
        }

        public static void Ex6()
        {
            // Ler um número inteiro N e calcular todos os seus divisores.
            Console.Write("Digite um número inteiro: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"Os divisores de {N} são: ");
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0.0)
                    Console.WriteLine(i);
            }
        }

        public static void Ex7()
        {
            //Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            //começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            //exemplo.
            Console.Write("Digite um número inteiro: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {   
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }

    }
}
