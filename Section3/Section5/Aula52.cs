using Section5;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5
{
    internal class Aula52
    {
        // Sobrecarga
        public static void Aula_52()
        {
            //Produto p = new Produto("TV", 500.00, 10);
            //Console.WriteLine(p);

            string nome;
            double preco;
            int quantidade;

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //quantidade = int.Parse(Console.ReadLine());

            //Produto p = new Produto(nome, preco, quantidade);
            Produto p = new Produto(nome, preco); // Usando o construtor de 2 argumentos (Sobrecarga)

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado em estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }

    }
}
