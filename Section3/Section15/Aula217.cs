using System;
using System.Collections.Generic;

namespace Section15
{
    internal class Aula217
    {
        public static void Aula_217()
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));
            Console.WriteLine(set.Contains("Computer"));

            foreach (string p in set)
                Console.WriteLine(p);
        }
    }
}
