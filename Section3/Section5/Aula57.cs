using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5
{
    internal class Aula57
    {
        // Auto Properties
        public static void Aula_57()
        {
            ProdutoAutoPropert p = new ProdutoAutoPropert("TV", 500.00, 10);

            //p.Quantidade = -10;
            p.Nome = "Teve";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
