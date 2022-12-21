using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7
{
    internal class Aula86
    {
        // Sintaxe alternativa - switch-case
        public static void Aula_86()
        {
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda-feira";
                    break;
                case 3:
                    dia = "Terça-feira";
                    break;
                case 4:
                    dia = "Quarta-feira";
                    break;
                case 5:
                    dia = "Quinta-feira";
                    break;
                case 6:
                    dia = "Sexta-feira";
                    break;
                case 7:
                    dia = "Sábado";
                    break;
                default:
                    dia = "Valor inválido";
                    break;
            }
            Console.WriteLine("Dia: " + dia);
        }
    }
}
