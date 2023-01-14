namespace Section10.Aula146.Entities
{
    internal class PessoaJuridica : Pagador
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalcularImposto()
        {
            double imposto;

            if (NumeroFuncionarios <= 10)
            {
                imposto = RendaAnual * 0.16;
            }
            else
            {
                imposto = RendaAnual * 0.14;
            }

            return imposto;
        }
    }
}
