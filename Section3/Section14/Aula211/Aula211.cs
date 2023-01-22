using Section14.Aula211.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section14.Aula211
{
    internal class Aula211
    {
        /*
            Faça um programa para ler um arquivo contendo nomes de pessoas (um nome por
            linha), armazenando-os em uma lista. Depois, ordenar os dados dessa lista e mostra-los
            ordenadamente na tela. Nota: o caminho do arquivo pode ser informado "hardcode".

            (c:\temp\in.txt)
            Maria Brown
            Alex Green
            Bob Grey
            Anna White
            Alex Black
            Eduardo Rose
            Willian Red
            Marta Blue
            Alex Brown 
          
         */
        public static void Aula_211()
        {
            //string path = @"c:\temp\in.txt";
            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        List<string> list = new List<string>();
            //        while (!sr.EndOfStream)
            //        {
            //            list.Add(sr.ReadLine());
            //        }
            //        list.Sort();
            //        foreach(string str in list)
            //        {
            //            Console.WriteLine(str);
            //        }
            //    }
            //}
            //catch (IOException ex) 
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(ex.Message);
            //}

            /*
                Faça um programa para ler um arquivo contendo funcionários (nome e salário) no
                formato .csv, armazenando-os em uma lista. Depois, ordenar a lista por nome e mostrar
                o resultado na tela. Nota: o caminho do arquivo pode ser informado "hardcode".

                Maria Brown,4300.00
                Alex Green,3100.00
                Bob Grey,3100.00
                Anna White,3500.00
                Alex Black,2450.00
                Eduardo Rose,4390.00
                Willian Red,2900.00
                Marta Blue,6100.00
                Alex Brown,5000.00
            */

            string path = @"c:\temp\in2.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
