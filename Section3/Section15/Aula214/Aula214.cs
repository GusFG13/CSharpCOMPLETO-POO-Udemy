using Section15.Aula213;
using Section15.Aula214;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section15.Aula214
{
    internal class Aula214
    {
        public static void Aula_214()
        {
            /*
                Problema motivador 1 (reuso)
                Deseja-se fazer um programa que leia um conjunto de N números inteiros (N de
                1 a 10), e depois imprima esses números de forma organizada conforme
                exemplo. Em seguida, informar qual foi o primeiro valor informado.
                Criar um serviço de impressão:
                +--------------------------------+
                |          PrintService          |
                +--------------------------------+
                | + addValue(value : int) : void |
                | + first() : int                |
                | + print() : void               |
                +--------------------------------+
                Exemplo:
                How many values? 3
                10
                8
                23
                [10, 8, 23]
                First: 10
             */
            //PrintService printService = new PrintService();
            //PrintService<T> printService = new PrintService<T>();
            PrintService<int> printService = new PrintService<int>();
            //PrintService<string> printService = new PrintService<string>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //string x = Console.ReadLine();
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            ////int a = (int)printService.First();
            //int a = printService.First();
            //int b = a + 2;
            //Console.WriteLine(b);

            printService.Print();
            Console.WriteLine($"First: {printService.First()}");

        }
    }
}
