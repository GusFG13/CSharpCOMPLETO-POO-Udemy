using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    internal class Aula79
    {
        // Matrizes
        public static void Aula_79()
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); // número total de elementos
            Console.WriteLine(mat.Rank); // Número de dimensões da matriz
            Console.WriteLine("Num linhas: " + mat.GetLength(0));
            Console.WriteLine("Num colunas: " + mat.GetLength(1));

        }
    }
}
