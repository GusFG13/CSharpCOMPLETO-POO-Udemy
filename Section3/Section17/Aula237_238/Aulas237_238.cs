﻿using System;
using System.Collections.Generic;
using System.Linq;
using Section17.Aula237_238.Entities;

namespace Section17.Aula237_238
{
    class Aulas237_238
    {
        public static void Aulas_237_238()
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2};
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "Computer", Price = 1100.00, Category = c2 },
                new Product { Id = 2, Name = "Hammer", Price = 90.00, Category = c1 },
                new Product { Id = 3, Name = "TV", Price = 1700.00, Category = c3 },
                new Product { Id = 4, Name = "Notebook", Price = 1300.00, Category = c2 },
                new Product { Id = 5, Name = "Saw", Price = 80.00, Category = c1 },
                new Product { Id = 6, Name = "Tablet", Price = 700.00, Category = c2 },
                new Product { Id = 7, Name = "Camera", Price = 700.00, Category = c3 },
                new Product { Id = 8, Name = "Printer", Price = 350.00, Category = c3 },
                new Product { Id = 9, Name = "MacBook", Price = 1800.00, Category = c2 },
                new Product { Id = 10, Name = "Sound Bar", Price = 700.00, Category = c3 },
                new Product { Id = 11, Name = "Level", Price = 70.00, Category = c1 },
            };

            var r1 = products.Where(p => p.Price < 900.00 && p.Category.Tier == 1);
            //Console.WriteLine("TIER 1 AND PRICE < 900.00:");
            //foreach (var p in r1) 
            //    Console.WriteLine(p);

            Print("TIER 1 AND PRICE < 900.00:", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAME FROM PRODUCTS FROM TOOLS", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name}); //objeto anônimo dentro do select (não definido em uma classe)
                                                                                                                               // CategoryName = p.Category.Name é necessário para evitar ambiguidade com nome do campo p.Name
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(P => P.Price).ThenBy(P => P.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            var r5 = r4.Skip(2).Take(4); //pula os 2 primeiros elementos da lista e pega os próximos 4
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = products.First();
            Console.WriteLine("First test1: " + r6);

            //var r7 = products.Where(p => p.Price > 3000.00).First(); // resultado vazio - gera erro
            var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault(); // resultado vazio - retorna nulo
            Console.WriteLine("First or dafault test2: " + r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault(); // não funciona se o where trouxer mais de um resultado.
            //usando SingleOrDefault() o objeto r8 é um Product, se usasse apanas o where, seria uma lista de Product com apenas 1 elemento
            //var r8 = products.Where(p => p.Id > 3).SingleOrDefault(); //erro - where retorna mais de 1 elemento
            Console.WriteLine("Single or default test1: " + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);
            Console.WriteLine();

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            //var r13 = products.Where(p => p.Category.Id == 5).Average(p => p.Price); // erro, não existe elementos na categoria 
            Console.WriteLine("Category 1 Average prices: " + r13);

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); // caso lista retornada por Select(p => p.Price) seja vazia, DefaultIfEmpty retorna o valor indicado (0.0)
            Console.WriteLine("Category 5 Average prices: " + r14);

            //var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y); // erro caso Select retorne vazio
            var r15 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y); // 0.0 informado define um valor inicial default
            Console.WriteLine("Category 1 aggregate sum: " + r15);

            Console.WriteLine();
            var r16 = products.GroupBy(p => p.Category);
            foreach(IGrouping<Category, Product> group in r16)// semelhante a um dicionário, retornando chaves (no caso Category) e valores (lista de Products que tenham essa chave)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine(); 
            }
        }

        static void Print<T>(string message, IEnumerable<T> collection) 
        { 
            Console.WriteLine(message);
            foreach (T obj in collection)
                Console.WriteLine(obj);
            Console.WriteLine();
        }
    }
}
