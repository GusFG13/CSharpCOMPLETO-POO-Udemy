using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Section4
{
    internal class FuncionarioA45Ex2
    {
        /* 
         *    +----------------------------------------------+
         *    |                  Funcionário                 |
         *    +----------------------------------------------+
         *    | - Nome: string                               |
         *    | - SalarioBruto: double                       |
         *    | - Imposto: double                            |
         *    +----------------------------------------------+
         *    | + SalarioLiquido(): double                   |
         *    | + AumentarSalario(porcentagem: double): void |
         *    +----------------------------------------------+
         */

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto * (1 + (porcentagem / 100.00));
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
