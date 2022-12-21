using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7
{
    internal class Aula93
    {
        // DateTimeKind e padrão ISO 8601
        public static void Aula_93()
        {
            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            //Console.WriteLine("d1: " + d1);
            //Console.WriteLine("d1 kind: " + d1.Kind);
            //Console.WriteLine("d1 to Local: " + d1.ToLocalTime());// mantém a data, pois o tipo já é Local
            //Console.WriteLine("d1 to UTC: " + d1.ToUniversalTime());
            //Console.WriteLine();
            //Console.WriteLine("d2: " + d2);
            //Console.WriteLine("d2 kind: " + d2.Kind);
            //Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            //Console.WriteLine("d2 to UTC: " + d2.ToUniversalTime()); // mantém a data, pois o tipo já é UTC
            //Console.WriteLine();
            //Console.WriteLine("d3: " + d3);
            //Console.WriteLine("d3 kind: " + d3.Kind); // se não especificar o tipo, as conversões abaixo são aplicadas
            //Console.WriteLine("d3 to Local: " + d3.ToLocalTime()); 
            //Console.WriteLine("d3 to UTC: " + d3.ToUniversalTime());

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // padrão ISO 8601. Data Armazenada está no formato UTC. Parse irá converter para horário local

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 kind: " + d1.Kind); // tipo não especificado, faz ambas conversões abaixo
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to UTC: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2); // ao converter formato padrão ISO 8601, automaticamente define o tipo como local
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime()); // como já é local, a conversão não é aplicada
            Console.WriteLine("d2 to UTC: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyy-MM-ddTHH:mm:ssZ")); // cuidado!! a data deve ser convertida antes para o formato UTC antes de passar para string
            Console.WriteLine(d2.ToUniversalTime().ToString("yyy-MM-ddTHH:mm:ssZ")); // <- dessa forma
        }
    }
}
