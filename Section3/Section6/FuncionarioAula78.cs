using System;
using System.Globalization;

namespace Section6
{
    /* 
     *    +----------------------------------------------+
     *    |                  Funcionario                 |
     *    +----------------------------------------------+
     *    | - id: integer                                |
     *    | - nome: string                               |
     *    | - salario: double                            |
     *    +----------------------------------------------+
     *    | + AumentarSalario(porcentagem: double): void |
     *    +----------------------------------------------+
     */
    internal class FuncionarioAula78
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario * (1 + (porcentagem / 100.0));
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
