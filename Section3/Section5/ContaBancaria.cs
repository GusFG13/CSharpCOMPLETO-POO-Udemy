using System;
using System.Globalization;

namespace Section5
{
    /* 
    *    +-----------------------------------+
    *    |           ContaBancaria           |
    *    +-----------------------------------+
    *    | - Numero: integer                 |
    *    | - Titular: string                 |
    *    | - Saldo: double                   |
    *    +-----------------------------------+
    *    | + Deposito(quantia: double): void |
    *    | + Saque(quantia: double): void    |
    *    +-----------------------------------+
    */
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            //Saldo = depositoInicial;
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= (quantia + 5.00);
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
