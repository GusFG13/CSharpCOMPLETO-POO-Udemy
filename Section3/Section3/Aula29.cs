using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Section3
{
    internal class Aula29
    {
        //Exercícios propostos - parte 2
        public static void Ex1()
        {
            // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            int num = int.Parse(Console.ReadLine());
            if (num < 0 ) 
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }

        }
        public static void Ex2()
        {
            // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
        public static void Ex3()
        {
            /*
             * Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
             * Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
             * ordem crescente ou decrescente.
             */
            string[] entrada = Console.ReadLine().Split(' ');
            int A = int.Parse(entrada[0]);
            int B = int.Parse(entrada[1]);

            if ((A % B == 0) || (B % A) == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
        public static void Ex4()
        {
            //Leia a hora inicial e a hora final de um jogo.A seguir calcule a duração do jogo, sabendo que o mesmo pode
            //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            string[] entrada = Console.ReadLine().Split(' ');
            int inicio = int.Parse(entrada[0]);
            int fim = int.Parse(entrada[1]);
            if (inicio == fim)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else if (inicio < fim)
            {
                Console.WriteLine($"O JOGO DUROU {fim - inicio} HORA(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {(24 - inicio) + fim} HORA(S)");
            }
        }
        public static void Ex5()
        {
            // Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.A
            // seguir, calcule e mostre o valor da conta a pagar.
            // Código | Especificação   | Preço
            //--------+-----------------+---------
            //   1    | Cachorro Quente | R$ 4.00
            //   2    | X-Salada        | R$ 4.50
            //   3    | X-Bacon         | R$ 5.00
            //   4    | Torrada simples | R$ 2.00
            //   5    | Refrigerante    | R$ 1.50

            string[] entrada = Console.ReadLine().Split(' ');
            int codigo = int.Parse(entrada[0]);
            double quantidade = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            double preco;

            if (codigo == 1) 
                preco = 4.00;
            else if (codigo == 2)
                preco = 4.50;
            else if (codigo == 3)
                preco = 5.00;
            else if (codigo == 4)
                preco = 2.00;
            else
                preco = 1.50;

            Console.WriteLine($"Total: R$ {(preco * quantidade).ToString("F2",CultureInfo.InvariantCulture)}");
        }
        public static void Ex6()
        {
            /*
             * Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
             * seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
             * nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
             */
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num < 0)
                Console.WriteLine("Fora de intervalo");
            else if (num <= 25)
                Console.WriteLine("Intervalo [0,25]");
            else if (num <= 50)
                Console.WriteLine("Intervalo (25,50]");
            else if (num <= 75)
                Console.WriteLine("Intervalo (50,75]");
            else if (num <= 100)
                Console.WriteLine("Intervalo (75,100]");
            else
                Console.WriteLine("Fora de intervalo");
        }
        public static void Ex7()
        {
            /*
             * Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
             * de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
             * ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
             * Se o ponto estiver na origem, escreva a mensagem “Origem”.
             * Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
             * situação.
             *        y
             *       |
             *    Q2 | Q1
             *  -----+----- x
             *    Q3 | Q4
             *       |
             */

            string[] entrada = Console.ReadLine().Split(' ');
            double x = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double y = double.Parse(entrada[1], CultureInfo.InvariantCulture);

            if ((x == 0.0) && (y == 0.0))
                Console.WriteLine("Origem");
            else if (x == 0.0)
                Console.WriteLine("Eixo Y");
            else if (y == 0.0)
                Console.WriteLine("Eixo X");
            else
            {
                if (x > 0.0)
                    if (y > 0.0)
                        Console.WriteLine("Q1");
                    else
                        Console.WriteLine("Q4");
                else
                    if (y > 0.0)
                    Console.WriteLine("Q2");
                else
                    Console.WriteLine("Q3");
            }
        }
        public static void Ex8()
        {
            /*
             * Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
             * que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
             * qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
             * Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
             * mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
             * 
             *               Renda             | Imposto de Renda
             *    -----------------------------+------------------
             *    de 0.00 a R$ 2000.00         |      Isento
             *    de R$ 2000.01 até R$ 3000.00 |        8 %
             *    de R$ 3000.01 até R$ 4500.00 |       18 %
             *    acima de R$ 4500.00          |       28 %
             * 
             * Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
             * salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
             * de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
             * duas casas decimais.
             */
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0.0;
            if (salario <= 2000.00)
                Console.WriteLine("Isento");
            else if (salario < 3000.00)
            {
                imposto = (salario - 2000.00) * 0.08;
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (salario < 4500.00)
            {
                imposto = (3000 - 2000) * 0.08;
                imposto += (salario - 3000.00) * 0.18;
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                imposto = (3000.00 - 2000.00) * 0.08;
                imposto += (4500.00 - 3000.00) * 0.18;
                imposto += (salario - 4500.00) * 0.28;
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
