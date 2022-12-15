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
    internal class Aula33
    {
        public static void Ex1()
        {
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
            //incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.
            Console.Write("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.Write("Digite sua senha: ");
                senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Acesso Permitido");
        }

        public static void Ex2()
        {
            // Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
            // cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            // menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).
            int x = 1;
            int y = 1;
            string[] entrada;
            while(x != 0 && y != 0)
            {
                entrada = Console.ReadLine().Split();
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);
                if (x != 0 && y != 0) 
                {
                    if (x > 0)
                    {
                        if (y > 0)
                            Console.WriteLine("primeiro");
                        else
                            Console.WriteLine("quarto");
                    }
                    else
                    {
                        if (y > 0)
                            Console.WriteLine("segundo");
                        else
                            Console.WriteLine("terceiro");
                    }
                }                  
            }

        }

        public static void Ex3()
        {
            /*
             * Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
             * um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
             * 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
             * que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
             * mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
             * exemplo.
             */
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int codigo = -1;

            while (codigo != 4)
            {
                Console.Write("Digite o código do combústivel: ");
                codigo = int.Parse(Console.ReadLine());
                if (codigo == 1)
                    alcool++;
                else if (codigo == 2)
                    gasolina++;
                else if (codigo == 3)
                    diesel++;
                else if (codigo == 4)
                {
                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine($"Alcool: {alcool}");
                    Console.WriteLine($"Gasolina: {gasolina}");
                    Console.WriteLine($"Diesel: {diesel}");
                }
                else
                    Console.WriteLine("Código inválido!");
            }
            
        }
    }
}
