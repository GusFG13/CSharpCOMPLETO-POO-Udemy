using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    internal class Aula80
    {
        // Exercício resolvido (matrizes)
        /*
         * Fazer um programa para ler um número inteiro N e uma matriz de
         * ordem N contendo números inteiros. Em seguida, mostrar a diagonal
         * principal e a quantidade de valores negativos da matriz.
         * 
         * | Input:    | Output:
         * | 3         |
         * | 5 -3 10   | Main diagonal:
         * | 15 8 2    | 5 8 -4
         * | 7 9 -4    | Negative numbers = 2
         */
        public static void Aula_80()
        {
            Console.WriteLine("Digite um número inteiro N, para a ordem da matriz quadrada: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            int totalNegativos = 0;

            //int j;
            //for (int i = 0; i < n; i++)
            //{
            //    j = 0;
            //    foreach(string s in Console.ReadLine().Split())
            //    {
            //        mat[i,j] = int.Parse(s);
            //        j++;
            //    }
            //}

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("\nMain diagonal:");
            for (int i = 0; i< n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }

            //foreach (int num in mat)
            //{
            //    if (num < 0)
            //        totalNegativos++;

            //}

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                        totalNegativos++;
                }
            }
            Console.Write("\nNegative numbers = " + totalNegativos);
        }
    }
}
