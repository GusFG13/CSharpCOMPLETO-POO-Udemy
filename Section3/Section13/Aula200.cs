using System;
using System.Collections.Generic;
using System.IO;

namespace Section13
{
    internal class Aula200
    {
        public static void Aula_200()
        {
            string path = @"c:\temp\myfolder\file1.txt";

            try
            {
                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
                Console.WriteLine("GetFileName: " + Path.GetFileName(path));
                Console.WriteLine("GetExtension: " + Path.GetExtension(path));
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
                Console.WriteLine("GetTempPath: " + Path.GetTempPath()); //pasta temporária do sistema
            }
            catch (IOException e)
            {
                Console.WriteLine("An erros occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
