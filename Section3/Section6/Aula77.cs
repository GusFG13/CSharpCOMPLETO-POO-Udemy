using System;
using System.Collections.Generic;

namespace Section6
{
    internal class Aula77
    {
        // Listas - parte 2
        public static void Aula_77()
        {
            List<string> lista = new List<string>();

            // add - adiciona no final da lista
            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");

            // insert - pode especificar a posição
            lista.Insert(2, "Marco");

            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("list count: " + lista.Count);

            string s1 = lista.Find(x => x[0] == 'A');// função lambda - retorna x tal que x comece com A
            Console.WriteLine("Primeiro 'A': " + s1);

            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último 'A': " + s2);

            int p1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição primeiro 'A': " + p1);

            int p2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição último 'A': " + p2);

            List<string> resultado = lista.FindAll(x => x.Length == 5);

            foreach (string s in resultado)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("---------------------------------");
            
            /*
            lista.Remove("Alex");
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("---------------------------------");
            lista.RemoveAll(x => x[0] == 'M');

            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
            

            lista.RemoveAt(3);
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
            */
            lista.RemoveRange(1, 3);

            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
        }
    }
}
