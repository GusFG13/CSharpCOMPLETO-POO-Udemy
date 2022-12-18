using System;
using System.Globalization;

namespace Section5
{
    internal class ProdutoAutoPropert
    {
        private string _nome; // por convenção, em C# variáveis private começam coom underline e letra minúscula
        //se não houver lógica especial para definir métodos get e set, pode-se usar as auto properties
        //private double _preco;
        public double Preco { get; private set; } // private set indica que variável não pode ser alterada por outros arquivos
        //private int _quantidade;
        public int Quantidade { get; private set; }

        public ProdutoAutoPropert()
        {
        }

        public ProdutoAutoPropert(string nome, double preco, int quantidade)
        { 
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome 
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        /************************************************************************/
        // não são mais necessários pois foram definidos com auto properties
        //public double Preco
        //{
        //    get { return _preco; }
        //}

        //public int Quantidade
        //{
        //    get { return _quantidade; }
        //}
        /************************************************************************/

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
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
