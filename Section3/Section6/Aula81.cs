using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    internal class Aula81
    {
        // Exercício de fixação (matrizes)

        /*
         * Fazer um programa para ler dois números inteiros M e N, e depois ler
         * uma matriz de M linhas por N colunas contendo números inteiros,
         * podendo haver repetições. Em seguida, ler um número inteiro X que
         * pertence à matriz. Para cada ocorrência de X, mostrar os valores à
         * esquerda, acima, à direita e abaixo de X, quando houver, conforme
         * exemplo.
         * 
         * Exemplo:
         * 
         * 3 4
         * 10 8 15 12
         * 21 11 23 8
         * 14 5 13 19
         * 8
         * Position 0,1:
         * Left: 10
         * Right: 15
         * Down: 11
         * Position 1,3:
         * Left: 23
         * Up: 12
         * Down: 19
         */
        public static void Aula_81()
        {
            string[] aux = Console.ReadLine().Split();
            int M = int.Parse(aux[0]); // linhas
            int N = int.Parse(aux[1]); // colunas

            int[,] mat = new int[M, N];

            

            for (int i = 0; i < M; i++)
            {
                string[] numeros = Console.ReadLine().Split();
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(numeros[j]);
                }
            }

            int numProcurado = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] == numProcurado)
                    {
                        Console.WriteLine($"Position {i},{j}:");
                        //left
                        if (j > 0)
                            Console.WriteLine($"Left: {mat[i,j - 1]}");
                        //right
                        if (j < (N - 1))
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        //up
                        if (i > 0)
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        //down
                        if (i < (M -1))
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                    }
                }
            }
        }
    }
}
