using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Section13
{
    internal class Aula201
    {
        /*
            Fazer um programa para ler o caminho de um arquivo .csv
            contendo os dados de itens vendidos. Cada item possui um
            nome, preço unitário e quantidade, separados por vírgula. Você
            deve gerar um novo arquivo chamado "summary.csv", localizado
            em uma subpasta chamada "out" a partir da pasta original do
            arquivo de origem, contendo apenas o nome e o valor total para
            aquele item (preço unitário multiplicado pela quantidade),
            conforme exemplo.

            Source file:
                TV LED,1290.99,1
                Video Game Chair,350.50,3
                Iphone X,900.00,2
                Samsung Galaxy 9,850.00,2
            Output file (out/summary.csv):
                TV LED,1290.99
                Video Game Chair,1051.50
                Iphone X,1800.00
                Samsung Galaxy 9,1700.00
         */
        public static void Aula_201()
        {
            string path = @"c:\temp\ExAula201";
            string sourcePath = @"c:\temp\ExAula201\sales.csv";
            string targetPath = @"c:\temp\ExAula201\out\summary.csv";

            try
            {
                Directory.CreateDirectory(path + @"\out");
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.CreateText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        string[] line_fields = line.Split(',');
                        double total_revenue = double.Parse(line_fields[1], CultureInfo.InvariantCulture) * double.Parse(line_fields[2], CultureInfo.InvariantCulture);
                        string aux = line_fields[0] + "," + total_revenue.ToString("F2", CultureInfo.InvariantCulture);
                        sw.WriteLine(aux);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An erros occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
