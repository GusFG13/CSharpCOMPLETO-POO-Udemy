using System;
using Section16.Aula226.Extensions;

namespace Section16.Aula226
{
    internal class Aula226
    {
        /*
                Demo 1
                Vamos criar um extension method chamado "ElapsedTime()" no struct
                DateTime para apresentar um objeto DateTime na forma de tempo
                decorrido, podendo ser em horas (se menor que 24h) ou em dias caso
                contrário. Por exemplo:

                DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
                Console.WriteLine(dt.ElapsedTime());

                "4.5 hours"
                "3.2 days"
         */
        //public static void Aula_226()
        //{
        //    DateTime dt = new DateTime(2023, 01, 23, 12, 55, 45);
        //    Console.WriteLine(dt.ElapsedTime());
        //}



        /*
                Demo 2
                Vamos criar um extension method chamado "Cut(int)" na classe String
                para receber um valor inteiro como parâmetro e gerar um recorte do
                string original daquele tamanho. Por exemplo:

                String s1 = "Good morning dear students!";
                Console.WriteLine(s1.Cut(10));

                "Good morni..."
         */

        public static void Aula_226()
        {
            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
