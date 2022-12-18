using System;
using System.Globalization;

namespace Section5
{
    internal class ContaCorrenteMySol
    {
        private int NumCC { get; }
        private string NomeCorrentista { get; }
        private readonly double Taxa = 5.00;
        public double Saldo { get; private set; }

        public ContaCorrenteMySol(int numCC, string nomeCorrentista)
        {
            NumCC = numCC;
            NomeCorrentista = nomeCorrentista; 
        }
        public ContaCorrenteMySol(int numCC, string nomeCorrentista, double depInicial) : this(numCC, nomeCorrentista)
        {
            NumCC = numCC;
            NomeCorrentista = nomeCorrentista;
            Depositar(depInicial);
        }

        public void Depositar(double quantidade)
        {
            Saldo += quantidade;
        }

        public void Sacar(double quantidade)
        {
            Saldo -= quantidade;
            Saldo -= Taxa;
        }

        public override string ToString()
        {
            return "Conta "
                + NumCC
                + ", Titular: "
                + NomeCorrentista
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
