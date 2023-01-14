using System.Globalization;

namespace Section10.Aula146.Entities
{
    abstract class Pagador
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Pagador()
        {
        }

        public Pagador(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalcularImposto();

        public override string ToString()
        {
            return $"{Nome}: $ {CalcularImposto().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }


}
