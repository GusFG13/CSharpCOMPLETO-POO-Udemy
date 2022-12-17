using System;
using System.Globalization;

namespace Section5
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //public Produto() // Construtor padrão - sem inicialização
        //{ // se nenhum construtor for definido, este será o comportamento padrão (mesmo que ele não tenha sido escrito no código)

        //}

        //public Produto(string nome, double preco, int quantidade) // Construtor (sobrecarga)
        //{ // exige os 3 parâmetros na instanciação
        //    Nome = nome;
        //    Preco = preco;
        //    Quantidade = quantidade;
        //}

        //public Produto(string nome, double preco) // Construtor (sobrecarga)
        //{ // exige apenas 2 parâmetros na instanciação
        //    Nome = nome;
        //    Preco = preco;
        //    Quantidade = 5;
        //}

        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        { // : this - aproveita a quantidade do construtor padrão
            Nome = nome;
            Preco = preco;    
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        { // : this - aproveita nome e preco do construtor com 2 argumentos
          // essa forma de definição evita repetição de código
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
