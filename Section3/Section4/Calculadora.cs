namespace Section4
{
    internal class Calculadora
    {
        /************************************************************/
        /* métodos não static devem ser instanciados antes de usar  */
        /* exemplo:                                                 */
        /* Calculadora calc = new Calculadora();                    */
        /* double circ = calc.Circunferencia(raio);                 */
        /************************************************************/

        //public double Pi = 3.14;

        //public double Circunferencia(double r)
        //{
        //    return 2.0 * Pi * r;
        //}

        //public double Volume(double r)
        //{
        //    return (4.0 / 3.0) * Pi * Math.Pow(r, 3);
        //}

        /************************************************************/

        /************************************************************/
        /* métodos static não são instanciados antes de usar        */
        /* exemplo: double circ = Calculadora.Circunferencia(raio)  */
        /************************************************************/
        public static double Pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return (4.0 / 3.0) * Pi * Math.Pow(r, 3);
        }
        /************************************************************/
    }
}
