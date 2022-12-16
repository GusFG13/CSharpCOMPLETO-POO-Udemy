namespace Section4
{
    internal class ConversorDeMoeda
    {
        public static double TaxaIOF = 0.06;

        public static double ConverterDolarParaReal(double cotDolar, double quantDolar)
        {
            return (cotDolar * quantDolar) * (1 + TaxaIOF);
        }
    }
}
