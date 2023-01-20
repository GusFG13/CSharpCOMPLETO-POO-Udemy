using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section13
{
    internal class Aula197
    {
        public static void Aula_197()
        {
            //string path = @"c:\temp\fileX.txt";
            string path = @"c:\temp\file1.txt";
            try
            {
                //versão 1
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                //{
                //    using (StreamReader sr = new StreamReader(fs))
                //    {
                //        while (!sr.EndOfStream) //ler todas as linhas até o fim de arquivo
                //        {
                //            string line = sr.ReadLine();
                //            Console.WriteLine(line);
                //        }
                //    }
                //}

                //versão 2
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream) //ler todas as linhas até o fim de arquivo
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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
