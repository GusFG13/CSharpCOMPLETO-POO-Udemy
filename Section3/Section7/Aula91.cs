﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7
{
    internal class Aula91
    {
        // Propriedades e operações com DateTime
        public static void Aula_91()
        {
            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("12) Year: " + d.Year);

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            //string s1 = d.ToLongDateString();
            //string s2 = d.ToLongTimeString();
            //string s3 = d.ToShortDateString();
            //string s4 = d.ToShortTimeString();
            //string s5 = d.ToString();
            //string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            //string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
            //Console.WriteLine(s5);
            //Console.WriteLine(s6);
            //Console.WriteLine(s7);

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
            //DateTime d2 = d.AddHours(2);
            //DateTime d3 = d.AddMinutes(3);
            //DateTime d4 = d.AddDays(7);

            //Console.WriteLine(d);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);

            DateTime d1 = new DateTime(2022, 12, 15);
            DateTime d2 = new DateTime(2022, 12, 18);

            TimeSpan t =  d2.Subtract(d1);

            Console.WriteLine(t);
        }
    }
}
