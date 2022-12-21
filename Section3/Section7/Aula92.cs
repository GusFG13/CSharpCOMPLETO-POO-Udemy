﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7
{
    internal class Aula92
    {
        // Propriedades e operações com TimeSpan
        public static void Aula_92()
        {
            //TimeSpan t1 = TimeSpan.MaxValue;
            //TimeSpan t2 = TimeSpan.MinValue;
            //TimeSpan t3 = TimeSpan.Zero;

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);

            //TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            //Console.WriteLine(t);

            //Console.WriteLine("Dias: " + t.Days);
            //Console.WriteLine("Hours: " + t.Hours);
            //Console.WriteLine("Minutes: " + t.Minutes);
            //Console.WriteLine("Milliseconds: " + t.Milliseconds);
            //Console.WriteLine("Seconds: " + t.Seconds);
            //Console.WriteLine("Ticks: " + t.Ticks);

            //Console.WriteLine("TotalDays: " + t.TotalDays);
            //Console.WriteLine("TotalHours: " + t.TotalHours);
            //Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            //Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            //Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan soma = t1.Add(t2);
            TimeSpan diferenca = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan divi = t2.Divide(2.0);

            Console.WriteLine(soma);
            Console.WriteLine(diferenca);
            Console.WriteLine(mult);
            Console.WriteLine(divi);
        }
    }
}
