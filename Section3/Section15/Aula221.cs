using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section15
{
    internal class Aula221
    {
        /*
            Em um portal de cursos online, cada usuário possui um código único, representado por
            um número inteiro.
            Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode se
            matricular em quantos cursos quiser. Assim, o número total de alunos de um instrutor não
            é simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haver
            alunos repetidos em mais de um curso.
            O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
            Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar a
            quantidade total e alunos dele, conforme exemplo.

                How many students for course A? 3
                21
                35
                22
                How many students for course B? 2
                21
                50
                How many students for course C? 3
                42
                35
                13
                Total students: 6
         */
        public static void Aula_221()
        {
            List<char> cursos = new List<char> { 'A', 'B', 'C'};
            HashSet<int> alunos = new HashSet<int>();
            foreach(char c in cursos) 
            {
                Console.Write($"How many students for course {c}? ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    int aluno = int.Parse(Console.ReadLine());
                    alunos.Add(aluno);
                }
            }
            Console.WriteLine("Total students: " + alunos.Count());
        }
    }
}
