using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3
{
    internal class Aula28
    {
        // escopo e inicialização
        public static void Aula_28()
        {
            int x;

            x = 10;
            Console.WriteLine(x);


            double preco = 13.5;

            //double desconto;
            double desconto = 0.0;
            if (preco > 100.0)
            {
                //double desconto = preco * 0.1;
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
        }
    }
}
