using System;
using System.Globalization;

namespace Section5
{
    internal class ProdutoPropert
    {
        private string _nome; // por convenção, em C# variáveis private começam coom underline e letra minúscula
        private double _preco;
        private int _quantidade;

        public ProdutoPropert()
        {
        }

        public ProdutoPropert(string nome, double preco, int quantidade)
        { 
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome 
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                } //value - nome especial que recebe o parâmetro informado no set
            }
        }

        //public string GetNome()
        //{
        //    return _nome;
        //}
        //public void SetNome(string nome)
        //{
        //    if (nome != null && nome.Length > 1)
        //    {
        //        _nome = nome;
        //    }
        //}

        public double Preco
        {
            get { return _preco; }
        }

        //public double GetPreco()
        //{
        //    return _preco;
        //}

        public int Quantidade
        {
            get { return _quantidade; }
        }
        //public int GetQuantidade()
        //{
        //    return _quantidade;
        //}

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
