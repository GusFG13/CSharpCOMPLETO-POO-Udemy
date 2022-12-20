using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    internal class Aula75
    {
        // Sintaxe opcional: laço foreach
        public static void Aula_75()
        {
            string[] vet = new string[] { "Maria", "Bob", "Alex" };

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.WriteLine("\n-----------------------------\n");

            foreach (string obj in vet)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
