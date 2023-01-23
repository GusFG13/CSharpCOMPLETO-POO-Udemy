using Section15.Aula220.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section15
{
    internal class Aula223
    {
        /*
            Na contagem de votos de uma eleição, são gerados vários registros
            de votação contendo o nome do candidato e a quantidade de votos
            (formato .csv) que ele obteve em uma urna de votação. Você deve
            fazer um programa para ler os registros de votação a partir de um
            arquivo, e daí gerar um relatório consolidado com os totais de cada
            candidato.

        Input file example:
            Alex Blue,15
            Maria Green,22
            Bob Brown,21
            Alex Blue,30
            Bob Brown,15
            Maria Green,27
            Maria Green,22
            Bob Brown,25
            Alex Blue,31

        Execution:
            Enter file full path: c:\temp\in223.csv
            Alex Blue: 76
            Maria Green: 71
            Bob Brown: 61
         */
        public static void Aula_223()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        if (dict.ContainsKey(name))
                            dict[name] += votes;
                        else
                            dict[name] = votes;
                    }
                    
                }
                foreach (KeyValuePair<string, int> item in dict)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
