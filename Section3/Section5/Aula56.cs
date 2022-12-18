using System;

namespace Section5
{
    internal class Aula56
    {
        // Properties
        public static void Aula_56()
        {
            ProdutoPropert p = new ProdutoPropert("TV", 500.00, 10);

            //p.Quantidade = -10;
            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
