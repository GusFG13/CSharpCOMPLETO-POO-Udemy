using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4
{
    internal class Retangulo
    {
        /* 
         *    +-----------------------+
         *    |       Retângulo       |
         *    +-----------------------+
         *    | - Largura: double     |
         *    | - Altura: double      |
         *    +-----------------------+
         *    | + Area(): double      |
         *    | + Perimetro(): double |
         *    | + Diagonal(): double  |
         *    +-----------------------+
         */

        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura)  * 2.0;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }
}
