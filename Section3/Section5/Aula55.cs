using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5
{
    internal class Aula55
    {
        // Encapsulamento
        public static void Aula_55()
        {
            ProdutoEncaps p = new ProdutoEncaps("TV", 500.00, 10);

            //p.Quantidade = -10;

            p.SetNome("T");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}
