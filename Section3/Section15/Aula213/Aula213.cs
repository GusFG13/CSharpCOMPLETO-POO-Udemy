using System;
using System.Collections.Generic;


namespace Section15.Aula213
{
    internal class Aula213
    {
        public static void Aula_213()
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
            PrintService printService = new PrintService();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine($"First: {printService.First()}");

        }
    }
}
