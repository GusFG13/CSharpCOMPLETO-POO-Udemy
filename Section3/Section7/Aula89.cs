using System;
using System.Globalization;

namespace Section7
{
    internal class Aula89
    {
        // DateTime - representando data e hora
        public static void Aula_89()
        {
            //DateTime d1 = DateTime.Now;

            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Ticks); // forma como a data é armazenada (similar ao Excel)

            //DateTime d1 = new DateTime(2022, 12, 20);
            //DateTime d2 = new DateTime(2022, 12, 20, 18, 35, 31);
            //DateTime d3 = new DateTime(2022, 12, 20, 18, 35, 31, 543);
            //DateTime d4 = DateTime.Now;
            //DateTime d5 = DateTime.Today;
            //DateTime d6 = DateTime.UtcNow;


            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);

            //DateTime d1 = DateTime.Parse("2000-08-15");
            //DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

            //DateTime d3 = DateTime.Parse("13/06/2014");
            //DateTime d4 = DateTime.Parse("13/06/2014 15:07:45");

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);

            DateTime d1 = DateTime.ParseExact("2010-04-16", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("15/08/2000 13:06:41", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            
            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}
