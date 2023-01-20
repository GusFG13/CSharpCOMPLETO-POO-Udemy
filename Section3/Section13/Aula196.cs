using System;
using System.IO;

namespace Section13
{
    internal class Aula196
    {
        public static void Aula_196()
        {

            // Versão 1 : com FileStream
            //string path = @"c:\temp\file1.txt";
            //FileStream fs = null;
            //StreamReader sr = null;

            //try
            //{
            //    fs = new FileStream(path, FileMode.Open);
            //    sr = new StreamReader(fs);

            //    string line = sr.ReadLine();
            //    Console.WriteLine(line);
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An erros occurred");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (sr != null) sr.Close();
            //    if (fs != null) fs.Close();
            //}

            // Versão 2 : com File
            string path = @"c:\temp\file1.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) //ler todas as linhas até o fim de arquivo
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An erros occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();

            }
        }
    }
}
