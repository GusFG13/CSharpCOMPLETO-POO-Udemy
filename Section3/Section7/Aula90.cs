using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7
{
    internal class Aula90
    {
        // TimeSpan - representando durações
        public static void Aula_90()
        {
            //TimeSpan t1 = new TimeSpan(0, 1, 30);

            //Console.WriteLine(t1);
            //Console.WriteLine(t1.Ticks);

            //TimeSpan t1 = new TimeSpan();
            //TimeSpan t2 = new TimeSpan(900000000L);
            //TimeSpan t3 = new TimeSpan(2, 15, 53);
            //TimeSpan t4 = new TimeSpan(4, 5, 17, 58);
            //TimeSpan t5 = new TimeSpan(7, 4, 26, 31, 249);


            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);

            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(2.5);
            TimeSpan t3 = TimeSpan.FromMinutes(58.25);
            TimeSpan t4 = TimeSpan.FromSeconds(3.5);
            TimeSpan t5 = TimeSpan.FromMilliseconds(4.7);
            TimeSpan t6 = TimeSpan.FromTicks(600000000L);



            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}
