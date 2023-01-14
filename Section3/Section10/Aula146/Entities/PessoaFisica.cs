namespace Section10.Aula146.Entities
{
    class PessoaFisica : Pagador
    {
    

        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalcularImposto()
        {
            double imposto;

            if ( RendaAnual < 20000.00)
            {
                imposto = RendaAnual * 0.15;
            }
            else
            {
                imposto = RendaAnual * 0.25;
            }

            if (GastosSaude > 0.00)
            {
                imposto -= (GastosSaude * 0.5);
            }

            return imposto;
        }

    }
}
